using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskRule.Models
{
    public class MemberBase
    {
        private int id;
        private string name;
        private string pwd;
        private string phone;
        private string email;
        private string birthday;
        private string gender;
        private string nickName;
        private int lastScore;
        private int totalScore;
        private string binding;
        private string realName;
        private string regchannel;
        private string nowchannel;



        /// <summary>
        /// 用户编号
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        /// <summary>
        /// 手机号码（不是座机号）
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        /// <summary>
        /// 电子邮件地址
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        /// <summary>
        /// 性别(男、女)
        /// </summary>
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        private string source;
        /// <summary>
        /// 网站来源
        /// </summary>
        public string Source
        {
            get { return source; }
            set { source = value; }
        }
        private string remark;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        /// <summary>
        /// 剩余积分
        /// </summary>
        public int LastScore
        {
            get { return lastScore; }
            set { lastScore = value; }
        }


        /// <summary>
        /// 总积分
        /// </summary>
        public int TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }
        /// <summary>
        /// 手机号绑定：0:未绑定，1:已绑定
        /// </summary>
        public string Binding
        {
            get { return binding; }
            set { binding = value; }
        }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName
        {
            get { return realName; }
            set { realName = value; }
        }
        /// <summary>
        /// 用户注册渠道
        /// </summary>
        public string RegChannel
        {
            get { return regchannel; }
            set { regchannel = value; }
        }
        /// <summary>
        /// 用户注册渠道
        /// </summary>
        public string NowChannel
        {
            get { return nowchannel; }
            set { nowchannel = value; }
        }
    }
}