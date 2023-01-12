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
using NorthwindDTO;
using WinNorthwind.Utils;
using System.IO;

namespace WinNorthwind
{
    public partial class frmEmployee : Form
    {
        EmployeeService srv = new EmployeeService();
        List<EmployeeDTO> allList = null;
        string search;

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitDataGridView(dgvEmp);

            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "FirstName", "FirstName", frosen:true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "LastName", "LastName", frosen: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "Title", "Title", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "BirthDate", "BirthDate", 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "HireDate", "HireDate", 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "HomePhone", "HomePhone", 150);

            DataGridViewUtil.AddGridTextBoxColumn(dgvEmp, "EmployeeID", "EmployeeID", visible: false);

            //=========================================

            picEmp.ImageLocation = "image/noimage.png";

            //폼이 로드될때 전체 직원정보를 조회해서 바인딩하고,
            //조회버튼을 클릭할때는 전체 직원정보에서 필터링해서 바인딩
            allList = srv.GetAllEmployee();
            dgvEmp.DataSource = allList;

            tabControl1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {//사진등록
            //파일열기 다이얼로그를 보여주고, 선택한 파일의 이미지를 pictureBox컨트롤에 바인딩
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picEmp.ImageLocation = dlg.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //유효성체크 (입력여부 체크, 정규화 체크)
            string errMsg = CommonUtil.InputTextCheck(panel1);
            if (errMsg.Length > 0)
            {
                MessageBox.Show(errMsg);
                return;
            }

            if (! CommonUtil.IsPhoneNumber(txtHomePhone.Text))
            {
                MessageBox.Show("전화번호 형식이 아닙니다.");
                return;
            }
            //처리
            //1. 이미지를 byte[]로 변환
            //FileStream fs = new FileStream(picEmp.ImageLocation, FileMode.Open, FileAccess.Read);
            //byte[] bImage = new byte[fs.Length];
            //fs.Read(bImage, 0, (int)fs.Length);

            byte[] bImage = CommonUtil.ImageToByte(picEmp.Image);

            //2. DTO를 생성
            EmployeeDTO newEmp = new EmployeeDTO
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Title = txtTitle.Text,
                BirthDate = dtpBirthDate.Value.ToShortDateString(),
                HireDate = dtpHireDate.Value.ToShortDateString(),
                HomePhone = txtHomePhone.Text,
                Notes = txtNotes.Text,
                Photo = bImage
            };

            //3. 서비스 등록 메서드 호출
            bool result = srv.AddEmployee(newEmp);
            if (result)
            {
                MessageBox.Show("사원이 등록되었습니다.");
            }
            else
            {
                MessageBox.Show("등록 중 오류가 발생했습니다. 다시 시도하여 주십시오.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//조회버튼
            search = txtKeyword.Text.Trim(); //검색어

            //검색어가 없는 경우는 전체 사원목록을 보여주고
            if (search.Length < 1)
            {
                dgvEmp.DataSource = null;
                dgvEmp.DataSource = allList;
            }
            //검색어가 있는 경우는 검색조건에 따라서 전체 사원목록을 필터링해서 보여준다.
            else 
            {
                frmWaitAsyncPop pop = new frmWaitAsyncPop(EmployeeDataBinding);
                pop.ShowDialog();
            }
        }

        private void EmployeeDataBinding()
        {
            List<EmployeeDTO> list = null;

            if (rdoName.Checked)
            {
                list = (from emp in allList
                        where emp.FirstName.Contains(search) || emp.LastName.Contains(search)
                        select emp).ToList();
            }
            else if (rdoTitle.Checked)
            {
                list = allList.FindAll((emp) => emp.Title.ToLower().Contains(search.ToLower()));
            }
            else
            {
                list = allList.Where((emp) => emp.HireDate.Contains(search)).ToList();
            }

            this.Invoke(new Action(() => dgvEmp.DataSource = null));
            this.Invoke(new Action(() => dgvEmp.DataSource = list));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtKeyword.Text = "";
            rdoName.Checked = true;
        }

        private void dgvEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //유효성체크
            if (e.RowIndex < 0) return;

            //선택한 사원의 EmployeeID 값을 얻어와서
            int empId = Convert.ToInt32(dgvEmp["EmployeeID", e.RowIndex].Value);

            //DB에서 EmployeeID 값의 상세정보를 조회해서 EmployeeDTO로 전달받는다.
            EmployeeDTO emp = srv.GetEmployeeInfo(empId);

            //EmployeeDTO의 속성을 각 컨트롤에 바인딩
            if (emp != null)
            {
                lblEmployeeID.Text = emp.EmployeeID.ToString();
                txtFirstName2.Text = emp.FirstName;
                txtLastName2.Text = emp.LastName;
                txtTitle2.Text = emp.Title;
                dtpBirthDate2.Value = Convert.ToDateTime(emp.BirthDate);
                dtpHiredDate2.Value = Convert.ToDateTime(emp.HireDate);
                txtHomePhone2.Text = emp.HomePhone;
                txtNotes2.Text = emp.Notes;

                //byte[] => Image로 변환해서 picturebox에 바인딩
                //MemoryStream ms = new MemoryStream(emp.Photo);
                //picEmp2.Image = Image.FromStream(ms);

                //Image.FromStream(ms) 에서 오류가 발생하는 경우
                //정상적인 이미지 포맷이 아니거나, 적절한 메타정보가 없는 경우에 오류가 발생할 수 있다.
                
                picEmp2.Image = CommonUtil.ByteToImage(emp.Photo);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string saveFilename = dlg.FileName;
                ExcellEmployeeExport(saveFilename);
            }
        }

        private void ExcellEmployeeExport(string saveFilename)
        {
            List<EmployeeDTO> list = (List<EmployeeDTO>)dgvEmp.DataSource;

            string errMsg = ExcelUtil.ExcelExportListDTO<EmployeeDTO>(list, saveFilename, "Notes|Photo");
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
