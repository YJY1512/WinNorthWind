using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDTO
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }

        // 1. DB에서 DateTime으로 정의된 컬럼을 string 속성으로 갖고 오려면...
        //  => select 쿼리문에서 DateTime 컬럼을 string 으로 형변환해서 쿼리문작성
        //  => convert(varchar(10), OrderDate, 23) OrderDate

        // 2. 값타입의 속성에 DB의 NULL값을 맵핑하려면, nullable타입으로 정의
        public string CompanyName { get; set; }
        public string EmpName { get; set; }
        public string ShippedDate { get; set; }
        public int? ShipVia { get; set; }  //DB의 조회된 값이 null로 나오는 경우, 속성값도 null
        public string ShipCompanyName { get; set; }
        public decimal? Freight { get; set; }  //
    }
}
