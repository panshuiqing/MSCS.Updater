using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OPZZ.MSCS.Updater.Core
{
    /// <summary>
    /// MSCS的语义化版本类
    /// </summary>
    public class MSCSVersion
    {
        public MSCSVersion(int major, int minor, int third, int fourth)
        {
            this.Major = major;
            this.Minor = minor;
            this.Third = third;
            this.Fourth = fourth;
        }

        public MSCSVersion(string version)
        {
            if (string.IsNullOrEmpty(version))
            {
                throw new ArgumentNullException(nameof(version), "版本字符串不能为空");
            }

            ParseVersion(version);
        }

        /// <summary>
        /// 主版本号
        /// </summary>
        public int Major { get; private set; }

        /// <summary>
        /// 次版本号
        /// </summary>
        public int Minor { get; private set; }

        /// <summary>
        /// 第三位
        /// </summary>
        public int Third { get; private set; }

        /// <summary>
        /// 第四位
        /// </summary>
        public int Fourth { get; private set; }

        /// <summary>
        /// 第一个版本
        /// </summary>
        /// <returns></returns>
        public static MSCSVersion First()
        {
            return new MSCSVersion(1, 0, 0, 0);
        }

        /// <summary>
        /// 提升版本号
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 逢9进1，比如1.0.0.9 -> 1.0.1.0
        /// </remarks>
        public MSCSVersion Increase()
        {
            int major = this.Major;
            int minor = this.Minor;
            int third = this.Third;
            int fourth = this.Fourth;

            if (fourth < 9)
            {
                fourth++;
            }
            else
            {
                fourth = 0;
            }

            if (fourth == 0)
            {
                if (third < 9)
                {
                    third++;
                }
                else
                {
                    third = 0;
                }
            }

            if (fourth == 0 && third == 0)
            {
                if (minor < 9)
                {
                    minor++;
                }
                else
                {
                    minor = 0;
                }
            }

            if (fourth == 0 && third == 0 && minor == 0)
            {
                major++;
            }

            return new MSCSVersion(major, minor, third, fourth);
        }

        public override string ToString()
        {
            return $"{Major}.{Minor}.{Third}.{Fourth}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var verson2 = obj as MSCSVersion;
            if (verson2 == null)
            {
                return false;
            }

            return this.Major == verson2.Major &&
                this.Minor == verson2.Minor &&
                this.Third == verson2.Third &&
                this.Fourth == verson2.Fourth;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(MSCSVersion v1, MSCSVersion v2)
        {
            if (ReferenceEquals(v1, v2))
            {
                return true;
            }

            if (ReferenceEquals(v1, null) || ReferenceEquals(v2, null))
            {
                return false;
            }

            return v1.Equals(v2);
        }

        public static bool operator !=(MSCSVersion v1, MSCSVersion v2)
        {
            return !(v1 == v2);
        }

        private void ParseVersion(string version)
        {
            if (!Regex.IsMatch(version, @"^([1-9])+(\d)*\.(\d){1}\.(\d){1}\.(\d){1}$", RegexOptions.Compiled))
            {
                throw new IncorrectVersionException("字符串不是有效的版本格式");
            }

            var values = version.Split('.');
            this.Major = int.Parse(values[0]);
            this.Minor = int.Parse(values[1]);
            this.Third = int.Parse(values[2]);
            this.Fourth = int.Parse(values[3]);
        }
    }

}
