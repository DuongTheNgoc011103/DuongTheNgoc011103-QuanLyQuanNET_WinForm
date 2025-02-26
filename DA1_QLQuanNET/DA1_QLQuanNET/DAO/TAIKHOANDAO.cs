using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_QLQuanNET.DAO
{
    public class TAIKHOANDAO
    {
        private static TAIKHOANDAO instance;

        public static TAIKHOANDAO Instance
        {
            get
            {
                if (instance == null) TAIKHOANDAO.instance = new TAIKHOANDAO();
                return TAIKHOANDAO.instance;
            }
            private set
            {
                TAIKHOANDAO.instance = value;
            }
        }

        //Sửa Thông tin Admin
        public void SuaTTADMIN(string taiKhoan, string matKhau, string AnhAD)
        {
            string q = "UPDATE TAIKHOAN SET TaiKhoan = N'" + taiKhoan + "', MatKhau = N'" + matKhau + "', AnhAD = N'" + AnhAD + "'";
            Functions.Instance.RunQuery(q);
        }
    }
}