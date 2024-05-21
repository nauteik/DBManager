using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBManager.Service
{
    public class Validator
    {
        private static Validator instance;

        public static Validator Instance { get => instance == null ? new Validator(): instance; set => instance = value; }

        public string validEmail(string email)
        {
            if(email.Count(c => c == '@') != 1)
            {
                return "Email không hợp lệ";
            }
            string pattern = @"[^@]{2,64}@[^.]{2,253}\.[0-9a-z-.]{2,63}";
            if (Regex.IsMatch(email, pattern)) return "";
            return "Email không hợp lệ";
        }
        public string validPastDate(DateTime date)
        {
            DateTime now = DateTime.Now;
            now = now.AddHours(23 - now.Hour).AddMinutes(59 - now.Minute).AddSeconds(59 - now.Second);
            if (date > now) return "Ngày không hợp lệ";
            return "";
        }
        public string validFutureDate(DateTime date)
        {
            DateTime now = DateTime.Now;
            now = now.AddHours(23 - now.Hour).AddMinutes(59 - now.Minute).AddSeconds(59 - now.Second);
            if (date < now) return "Ngày không hợp lệ";
            return "";
        }
        public string validPhone(string phone)
        {
            if(phone == "")
            {
                return "Không được để trống";
            }
            string pattern = @"^\d+$";
            if (phone.All(c => char.IsDigit(c) || c == ' '))
                return "";
            return "Nội dung chỉ bao gồm số";
        }
        public string validEncode(string text)
        {
            if(text == "")
            {
                
                return "Không được để trống";
            }
            if(text.Contains(" "))
            {
                return "Không được có dấu cách";
            }

            if(Regex.IsMatch(text, @"^[A-Za-z0-9][A-Za-z0-9@#%&'\-\s\.\,*]*$"))
            {
                return "";
            }
            return "Không được có dấu";
        }
        public string validEmpty(string text)
        {
            if(text == "")
            {
                return "Không được để trống";
            }
            else
            {
                return "";
            }
        }
    }
    
}
