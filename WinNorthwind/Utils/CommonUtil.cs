using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindDTO;
using System.Text.RegularExpressions;
using System.Drawing;
using System.ComponentModel;

namespace WinNorthwind.Utils
{
    class CommonUtil
    {
        public static void ComboBinding(ComboBox cbo, List<ComboItemDTO> src
                                        , string category
                                        , bool blankItem = true, string blankText = "선택")
        {
            //var list = (from item in src
            //            where item.Category == category
            //            select item).ToList();

            //var list = src.Where<ComboItemDTO>((c) =>c.Category == category).ToList();

            var list = src.FindAll((c) => c.Category == category);

            if (blankItem)
            {
                ComboItemDTO newItem = new ComboItemDTO()
                {
                    Category = category,
                    Code = "",
                    Name = blankText
                };
                list.Insert(0, newItem);
            }

            cbo.DisplayMember = "Name";
            cbo.ValueMember = "Code";
            cbo.DataSource = list;
        }

        public static bool IsPhoneNumber(string input)
        {
            string phonePattern = @"\d{2,3}-\d{3,4}-\d{4}";
            if (!Regex.IsMatch(input, phonePattern))
                return false;
            else
                return true;
        }

        //반환문자열이 빈문자열이면 필수항목 모두 입력한 경우
        public static string InputTextCheck(Panel pnl)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Control ctrl in pnl.Controls)
            {
                if (ctrl is GudiTextBox txt)
                {
                    if (txt.InputType == validType.Required
                         || txt.InputType == validType.RequiredNumeric)
                    {
                        if (string.IsNullOrWhiteSpace(txt.Text))
                        {
                            string msg = $"- {txt.Tag.ToString()}은 필수항목입니다.";
                            sb.AppendLine(msg);
                        }
                    }
                }
            }

            return sb.ToString();
        }

        //byte[] => image
        public static Image ByteToImage(byte[] data)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            return (Bitmap)tc.ConvertFrom(data);
        }

        //image => byte[]
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter ic = new ImageConverter();
            return (byte[])ic.ConvertTo(img, typeof(byte[]));
        }
    }
}
