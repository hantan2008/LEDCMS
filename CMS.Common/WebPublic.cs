using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CMS.Common
{
    public class WebPublic
    {
        /// <summary>
        /// 清除所有脚本
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string InputTexts(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            text = Regex.Replace(text, "[\\s]{2,}", " ");	//two or more spaces
            text = Regex.Replace(text, "(<[b|B][r|R]/*>)+|(<[p|P](.|\\n)*?>)", "\n");	//<br>
            text = Regex.Replace(text, "(\\s*&[n|N][b|B][s|S][p|P];\\s*)+", " ");	//&nbsp;
            text = Regex.Replace(text, "<(.|\\n)*?>", string.Empty);	//any other tags
            text = text.Replace("'", "''");
            return text;
        }
    }
}
