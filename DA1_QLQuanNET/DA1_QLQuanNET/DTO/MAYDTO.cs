using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA1_QLQuanNET.DTO
{
    public class MAYDTO
    {
        // Các trường dữ liệu
        private string maMay;

        private string tenMay;
        private string trangThaiMay;

        // Các thuộc tính
        public string MaMay { get => maMay; set => maMay = value; }

        public string TenMay { get => tenMay; set => tenMay = value; }
        public string TrangThaiMay { get => trangThaiMay; set => trangThaiMay = value; }

        // Các hàm tạo
        // Hàm tạo mặc định không tham số
        public MAYDTO()
        {
        }

        // Hàm tạo với các tham số maMay, tenMay, trangThaiMay
        public MAYDTO(string maMay, string tenMay, string trangThaiMay)
        {
            MaMay = maMay;
            TenMay = tenMay;
            TrangThaiMay = trangThaiMay;
        }

        // Hàm tạo từ một DataRow
        public MAYDTO(DataRow d)
        {
            MaMay = d["MaMay"].ToString();
            TenMay = d["TenMay"].ToString();
            TrangThaiMay = d["TrangThaiMay"].ToString();
        }
    }
}