using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.admin
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Imblogin_Click(object sender, ImageClickEventArgs e)
        {
            this.lberr.Text = "";//清空错误信息

            CMS.Model.CMS_admin admin = null;
            string userLoginName = CMS.Common.WebPublic.InputTexts(userloginname.Text);//获取登录名称
            string userLoginPwd = CMS.Common.WebPublic.InputTexts(userloginpwd.Text);//获取密码
            string CheckCode = CMS.Common.WebPublic.InputTexts(txtCheckCode.Text);//获取验证码

            CMS.DAL.CMS_Admin adminDAL = new CMS.DAL.CMS_Admin();
            admin = adminDAL.GetModelByAdmin_Name(userLoginName);
            
            if (admin == null)
            {
                this.lberr.Text = "您输入的管理员不存在，请联系网站管理员！";
                return;
            }
            else
            {
                bool bl = CheckAdminLogin(admin, userLoginName, userLoginPwd, CheckCode, this.lberr);
                if (bl)
                {
                    Response.Redirect("admin_index.aspx");
                }
            }
        }

        #region 判断管理员登陆是否合法
        /// <summary>
        /// 判断管理员登陆是否合法
        /// </summary>
        ///<param name="userLoginName">管理员对象类型</param>
        /// <param name="userLoginName">用户名</param>
        /// <param name="userLoginPwd">用户密码</param>
        /// <param name="CheckCode">验证码</param>
        /// <param name="lberr">错误记录的Label标签控件</param>
        /// <returns>合法的标志</returns>
        private bool CheckAdminLogin(CMS.Model.CMS_admin admin, string userLoginName, string userLoginPwd, string CheckCode, Label lberr)
        {
            bool bl = false;//判断登录是否合法标志            
            try
            {
                //验证码控制------start--------
                if (Request.Cookies["CheckCode"] == null)
                {
                    lberr.Text = "您的浏览器设置已被禁用 Cookies，您必须设置浏览器允许使用 Cookies 选项后才能使用本系统。";
                    lberr.Visible = true;
                }
                if (String.Compare(Request.Cookies["CheckCode"].Value, CheckCode, true) != 0)
                {
                    lberr.Text = "温馨提示：验证码错误，请输入正确的验证码。";
                    lberr.Visible = true;
                }//------end--------
                else
                {

                    //获取MD5加密后的登录密码
                    string MD5userLoginPwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(userLoginPwd, "MD5");
                    if ((!string.IsNullOrEmpty(userLoginName)) && (!string.IsNullOrEmpty(userLoginPwd)))
                    {
                        if (admin == null)
                        {
                            lberr.Text = "输入的用户不存在！";
                            lberr.Visible = true;
                            bl = false;
                        }
                        else
                        {
                            if (admin.Admin_State == 2)
                            {
                                lberr.Text = "温馨提示：您输入的账户以被冻结！";
                                lberr.Visible = true;
                                bl = false;
                            }
                            if (admin.Admin_ManageEndTime < DateTime.Now)
                            {
                                lberr.Text = "温馨提示：你的帐户已经过期！";
                                lberr.Visible = true;
                                bl = false;
                            }
                            if (admin.Admin_PassWord.ToString() == MD5userLoginPwd)
                            {
                                bl = true;
                            }
                            else
                            {
                                lberr.Text = "温馨提示：对不起！密码输入错误，请重新登录！";
                                lberr.Visible = true;
                                bl = false;
                            }
                        }

                    }

                }

            }
            catch
            {
                lberr.Text = "温馨提示：对不起！登录失败，请重新登录！";
                lberr.Visible = true;

            }

            return bl;
        }
        #endregion
    }
}
