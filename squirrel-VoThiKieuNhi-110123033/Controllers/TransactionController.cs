using Microsoft.AspNetCore.Mvc;

namespace squirrel_api_hoten_mssv.Controllers
{
    [ApiController]
    public class TransactionController : ControllerBase
    {
        // Model giao dịch
        public class Transaction
        {
            public int Id { get; set; }
            public string SoTaiKhoan { get; set; }
            public double SoTien { get; set; }
            public string LoaiGiaoDich { get; set; }
        }

        // Dữ liệu mẫu
        private static List<Transaction> danhSach = new List<Transaction>
        {
            new Transaction
            {
                Id = 1,
                SoTaiKhoan = "1023456789",
                SoTien = 500000,
                LoaiGiaoDich = "Nap tien"
            },

            new Transaction
            {
                Id = 2,
                SoTaiKhoan = "1023456789",
                SoTien = 200000,
                LoaiGiaoDich = "Rut tien"
            },

            new Transaction
            {
                Id = 3,
                SoTaiKhoan = "1098765432",
                SoTien = 1000000,
                LoaiGiaoDich = "Nap tien"
            },

            new Transaction
            {
                Id = 4,
                SoTaiKhoan = "1098765432",
                SoTien = 150000,
                LoaiGiaoDich = "Rut tien"
            },

            new Transaction
            {
                Id = 5,
                SoTaiKhoan = "1055566677",
                SoTien = 300000,
                LoaiGiaoDich = "Nap tien"
            }
        };

        // API GET
        [HttpGet]
        [Route("api/giaodich")]
        public IActionResult GetNapTien()
        {
            var ketQua = danhSach
                .Where(x => x.LoaiGiaoDich == "Nap tien")
                .ToList();

            return Ok(ketQua);
        }
    }
}