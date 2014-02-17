﻿using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.IO;
using CMS.Common;

namespace Web.Tools
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class SingleUpload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string _refilepath = context.Request.QueryString["ReFilePath"]; //取得返回的对象名称
            string _upfilepath = context.Request.QueryString["UpFilePath"]; //取得上传的对象名称
            int _iswater; //默认打水印
            if (!int.TryParse(context.Request.QueryString["IsWater"] as string, out _iswater))
            {
                _iswater = 1;
            }
            HttpPostedFile _upfile = context.Request.Files[_upfilepath];
            string _delfile = context.Request.Params[_refilepath];

            if (_upfile == null)
            {
                context.Response.Write("{msg: 0, msbox: \"请选择要上传文件！\"}");
                return;
            }
            UpLoad upFiles = new UpLoad();
            string msg = upFiles.fileSaveAs(_upfile, _iswater);
            //删除已存在的旧文件
            if (!string.IsNullOrEmpty(_delfile))
            {
                string _filename = Utils.GetMapPath(_delfile);
                if (File.Exists(_filename))
                {
                    File.Delete(_filename);
                }
            }
            //返回成功信息
            context.Response.Write(msg);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}