using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinNorthwind.Services;
using WinNorthwind.Utils;
using NorthwindDTO;

namespace WinNorthwind
{
    public partial class frmOrder : Form
    {
        OrderService srv = null;
        List<ProductInfoDTO> productList = null; //카테고리를 처음으로 선택할때
        List<OrderDetailDTO> cartList = null; //장바구니 추가를 처음으로 클릭할때

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            string[] category = { "Customer", "Employee", "Category", "Shipper" };

            srv = new OrderService();
            List<ComboItemDTO> list = srv.GetCommonCode(category);
            CommonUtil.ComboBinding(cboCustomer, list, "Customer");
            CommonUtil.ComboBinding(cboEmployee, list, "Employee");
            CommonUtil.ComboBinding(cboCategory, list, "Category");

            dtpRequiredDate.Value = DateTime.Now.AddDays(7);

            DataGridViewUtil.SetInitDataGridView(dgvCart);

            DataGridViewUtil.AddGridTextBoxColumn(dgvCart, "카테고리", "CategoryName", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCart, "제품명", "ProductName", 250);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCart, "단가", "UnitPrice", align:DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCart, "수량", "Quantity", align: DataGridViewContentAlignment.MiddleRight);

            DataGridViewUtil.AddGridTextBoxColumn(dgvCart, "OrderID", "OrderID", visible:false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCart, "ProductID", "ProductID", visible: false);

            //==========================================================================
            periodDateTime1.Period = PeriodType.Week1;
            CommonUtil.ComboBinding(cboCustomer2, list, "Customer");
            CommonUtil.ComboBinding(cboEmployee2, list, "Employee");
            CommonUtil.ComboBinding(cboShipper, list, "Shipper");

            //주문목록, 주문상세목록 데이터 그리드 뷰의 컬럼추가
            DataGridViewUtil.SetInitDataGridView(dgvOrder);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "주문ID", "OrderID");
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "거래처명", "CompanyName");
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "담당직원", "EmpName");
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "주문일", "OrderDate");
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "요청일", "RequiredDate");
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "배송일", "ShippedDate");
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "배송업체", "ShipCompanyName");
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "배송료", "Freight");

            DataGridViewUtil.SetInitDataGridView(dgvOrderDetail);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetail, "카테고리", "CategoryName");
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetail, "제품명", "ProductName");
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetail, "제품단가", "UnitPrice");
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetail, "주문수량", "Quantity");
            //-----------------------------------------------------------------------------
            tabControl1.SelectedTab = tabPage2;
            
            btnSearch.PerformClick();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex < 1) return;

            if (productList == null)
            {
                productList = srv.GetProductAllList();
            }

            //전체 제품중에서 선택된 카테고리에 해당하는 제품목록을 바인딩
            var selProdList = (from prod in productList
                               where prod.CategoryID == Convert.ToInt32(cboCategory.SelectedValue)
                               select new ComboItemDTO
                               {
                                   Code = prod.ProductID.ToString(),
                                   Name = prod.ProductName,
                                   Category = "Product"
                               }).ToList();
            CommonUtil.ComboBinding(cboProducts, selProdList, "Product");

            txtQuantityPerUnit.Text = txtUnitPrice.Text = "";
            nuQuantity.Value = 0;
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducts.SelectedIndex < 1) return;

            //productList.FindAll((p) => p.ProductID == Convert.ToInt32(cboProducts.SelectedValue)).FirstOrDefault();

            int selProdID = Convert.ToInt32(cboProducts.SelectedValue);
            ProductInfoDTO selProduct = productList.FirstOrDefault((p) => p.ProductID == selProdID);
            if (selProduct != null)
            {
                txtQuantityPerUnit.Text = selProduct.QuantityPerUnit;
                txtUnitPrice.Text = selProduct.UnitPrice.ToString("N2");
                nuQuantity.Value = selProduct.UnitsOnOrder;
                nuQuantity.Increment = (selProduct.UnitsOnOrder > 0) ? selProduct.UnitsOnOrder : 1;
            }
            else
            {
                txtQuantityPerUnit.Text = txtUnitPrice.Text = "";
                nuQuantity.Value = 0;
            }
        }

        private void btnCartAdd_Click(object sender, EventArgs e)
        {
            //유효성체크 (수량, 제품선택)
            if (cboProducts.SelectedIndex < 1 || nuQuantity.Value < 1)
            {
                MessageBox.Show("장바구니에 추가할 제품을 선택하여 주십시오.");
                return;
            }

            //처리
            if (cartList == null)
            {
                cartList = new List<OrderDetailDTO>();
            }

            //장바구니에 담겨진 제품이면 수량변경, 추가
            int selProdID = Convert.ToInt32(cboProducts.SelectedValue);

            int idx = cartList.FindIndex((p) => p.ProductID == selProdID);
            if (idx >= 0) //장바구니에서 찾았다.
            {
                cartList[idx].Quantity += (int)nuQuantity.Value;
            }
            else
            {
                OrderDetailDTO newItem = new OrderDetailDTO
                {
                    CategoryName = cboCategory.Text,
                    ProductID = Convert.ToInt32(cboProducts.SelectedValue),
                    ProductName = cboProducts.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    Quantity = (int)nuQuantity.Value
                };
                cartList.Add(newItem);
            }

            dgvCart.DataSource = null;
            dgvCart.DataSource = cartList;

            dgvCart.ClearSelection();
        }

        private void btnCartDel_Click(object sender, EventArgs e)
        {
            //유효성체크(삭제할 제품을 선택했는지 체크)
            if (dgvCart.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 제품을 선택하여 주십시오.");
                return;
            }

            string msg = $"{dgvCart["ProductName", dgvCart.SelectedRows[0].Index].Value} 제품을 장바구니에서 삭제하시겠습니까?";
            if (MessageBox.Show(msg, "장바구니 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //처리(cartList에서 해당 제품을 선택해서 삭제)
                int proId = Convert.ToInt32(dgvCart.SelectedRows[0].Cells["ProductID"].Value);

                int idx = cartList.FindIndex((p) => p.ProductID == proId);
                if (idx >= 0)
                {
                    cartList.RemoveAt(idx);

                    dgvCart.DataSource = null;
                    dgvCart.DataSource = cartList;

                    dgvCart.ClearSelection();
                }
            }

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //유효성체크(장바구니 제품, 고객, 직원 선택했는지 체크)
            if (cboCustomer.SelectedIndex < 1 || cboEmployee.SelectedIndex < 1)
            {
                MessageBox.Show("주문정보를 선택하여 주십시오.");
                return;
            }
            if (cartList == null || cartList.Count < 1)
            {
                MessageBox.Show("장바구니에 주문할 제품을 추가하여 주십시오.");
                return;
            }

            OrderDTO order = new OrderDTO
            {
                CustomerID = cboCustomer.SelectedValue.ToString(),
                EmployeeID = Convert.ToInt32(cboEmployee.SelectedValue),
                RequiredDate = dtpRequiredDate.Value.ToString("yyyy-MM-dd")
            };

            //처리 (Order, OrderDetails) => (order, cartList)
            bool result = srv.AddOrder(order, cartList);
            if (result)
            {
                MessageBox.Show("신규 주문등록이 완료되었습니다.");
                InitControl();
            }
            else
            {
                MessageBox.Show("다시 시도하여 주십시오.");
            }
        }

        private void InitControl()
        {
            cartList.Clear();
            dgvCart.DataSource = null;
            cboCustomer.SelectedIndex = cboEmployee.SelectedIndex = cboCategory
                .SelectedIndex = cboProducts.SelectedIndex = 0;
            dtpRequiredDate.Value = DateTime.Now.AddDays(7);

            txtQuantityPerUnit.Text = txtUnitPrice.Text = "";
            nuQuantity.Value = 0;
            //tabControl1.SelectedIndex = 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fromDt = periodDateTime1.dtFrom;
            string toDt = periodDateTime1.dtTo;
            string custID = cboCustomer2.SelectedValue.ToString();
            int empID = (cboEmployee2.SelectedIndex <1) ? 0 : Convert.ToInt32(cboEmployee2.SelectedValue);

            List<OrderDTO> list = srv.GetOrderSearchList(fromDt, toDt, custID, empID);
            
            dgvOrder.DataSource = list;

            //주문상세 컨트롤 클리어
            dgvOrderDetail.DataSource = null;
            foreach (Label lbl in panel3.Controls)
            {
                lbl.Text = "";
            }
            cboShipper.SelectedIndex = 0;
            dtpShippedDate.Value = DateTime.Now;
            txtFreight.Text = "";
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //유효성체크 (컬럼헤더부분을 클릭한 경우 무시)
            if (e.RowIndex < 0) return;

            //처리
            //주문번호를 얻어와서,
            int orderID = Convert.ToInt32(dgvOrder[0, e.RowIndex].Value);

            //주문번호의 상세주문내역을 조회하고 그 결과를 데이터그리드뷰에 바인딩
            List<OrderDetailDTO> list = srv.GetOrderDetail(orderID);
            dgvOrderDetail.DataSource = list;

            //주문번호의 내용을 리스트에서 찾아서 오른쪽 컨트롤에 바인딩
            List<OrderDTO> ordList = (List<OrderDTO>)dgvOrder.DataSource;
            OrderDTO curOrder = ordList.Find((o) => o.OrderID == orderID);
            if (curOrder != null)
            {
                lblOrderID.Text = curOrder.OrderID.ToString();
                lblCustomer.Text = curOrder.CompanyName;
                lblEmployee.Text = curOrder.EmpName;
                lblOrderDate.Text = curOrder.OrderDate;
                lblRequiredDate.Text = curOrder.RequiredDate;

                //주문번호의 배송내역이 있는 경우는 배송중, 배송완료인 상태로 주문삭제버튼을 비활성 처리
                //아직 배송처리가 되지 않은 경우는 배송처리 또는 주문삭제 모두 활성처리

                if (curOrder.ShipVia == null || curOrder.Freight == null)
                {//배송전
                    cboShipper.SelectedIndex = 0;
                    txtFreight.Text = "";

                    dtpShippedDate.Format = DateTimePickerFormat.Short;
                    dtpShippedDate.Value = DateTime.Now;

                    btnDelete.Enabled = true;
                    btnShip.Enabled = true;
                }
                else
                {//배송중, 배송완료
                    //배송정보를 바인딩
                    cboShipper.SelectedValue = curOrder.ShipVia.ToString();
                    txtFreight.Text = curOrder.Freight.ToString();

                    if (curOrder.ShippedDate == null)
                    {
                        dtpShippedDate.Format = DateTimePickerFormat.Custom;
                        dtpRequiredDate.CustomFormat = " ";
                    }
                    else
                    {
                        dtpShippedDate.Format = DateTimePickerFormat.Short;
                        dtpShippedDate.Value = Convert.ToDateTime(curOrder.ShippedDate);
                    }

                    btnDelete.Enabled = false;
                    btnShip.Enabled = false;
                }
            }


        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            //유효성체크
            if (string.IsNullOrWhiteSpace(lblOrderID.Text))
            {
                MessageBox.Show("배송처리할 주문정보를 선택하여 주십시오.");
                return;
            }

            if (cboShipper.SelectedIndex < 1 || string.IsNullOrWhiteSpace(txtFreight.Text))
            {
                MessageBox.Show("배송정보를 입력하세요.");
                return;
            }

            //처리
            OrderDTO order = new OrderDTO
            {
                OrderID = int.Parse(lblOrderID.Text),
                ShipVia = Convert.ToInt32(cboShipper.SelectedValue),
                ShippedDate = dtpShippedDate.Value.ToShortDateString(),
                Freight = Convert.ToDecimal(txtFreight.Text)
            };
            bool result = srv.UpdateOrder(order);
            if (result)
            {
                MessageBox.Show("배송처리가 완료되었습니다.");
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show("배송처리 중 오류발생, 다시 시도하여 주십시오.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //유효성체크
            if (string.IsNullOrWhiteSpace(lblOrderID.Text))
            {
                MessageBox.Show("삭제할 주문정보를 선택하여 주십시오.");
                return;
            }

            if (MessageBox.Show("주문정보를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) 
                    == DialogResult.Yes)
            {
                bool result = srv.DeleteOrder(int.Parse(lblOrderID.Text));
                if (result)
                {
                    MessageBox.Show("주문이 삭제되었습니다.");
                    btnSearch.PerformClick();
                }
                else
                {
                    MessageBox.Show("주문 삭제 중 오류발생. 다시시도하여 주십시오.");
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                List<OrderDTO> list = (List<OrderDTO>)dgvOrder.DataSource;

                string errMsg = ExcelUtil.ExcelExportListDTO<OrderDTO>(list, dlg.FileName, "");
                if (errMsg != null)
                {
                    MessageBox.Show(errMsg);
                }
                else
                {
                    MessageBox.Show("엑셀 다운로드 완료");
                }
            }
        }
    }
}
