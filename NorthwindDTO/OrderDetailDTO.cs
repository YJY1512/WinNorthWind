using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDTO
{
    public class OrderDetailDTO
    { //주문하기에서 저장으로 서비스에 전달할 목적
      //장바구니 목록으로 데이터그리드뷰에 바인딩할 목적
        public int OrderID { get; set; }
        public string CategoryName { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
