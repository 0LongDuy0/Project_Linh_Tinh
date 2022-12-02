using Controller.Sys.Tai_Khoan;
using Entity.Sys.Tai_Khoan;

namespace API_Linh_Tinh.Pages.Sys.F01001_Tai_Khoan.Components
{
    public partial class F0100101_Tai_Khoan_Managenment
    {
        public List<E_Sys_Tai_Khoan> v_arrData = new();
        protected override void OnInitialized()
        {
            Load_Data();
        }

        private void Load_Data()
        {
            C_Sys_Tai_Khoan v_objCtrlTai_Khoan = new C_Sys_Tai_Khoan();
            v_arrData = v_objCtrlTai_Khoan.List_Sys_Tai_Khoan();
        }
        
    }
}
