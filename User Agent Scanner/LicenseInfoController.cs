using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Agent_Scanner
{
    public class LicenseInfoController
    {
        private static LicenseInfoController _instance;
        public static LicenseInfoController Instance
        {
            get
            {
                if (_instance == null)
                {
                    return _instance = new LicenseInfoController();
                }
                return _instance;
            }
        }
        private LicenseInfoController() { }

        public LicenseInfo GetLicense()
        {
            if (!File.Exists(Program.licensePath))
            {
                return new LicenseInfo() { Type = LicenseType.Invalid };
            }

            var licenseTextEncrypted = File.ReadAllText(Program.licensePath);
            var activeKey = StringCipher.Decrypt(licenseTextEncrypted, Program.passwordToEncryptKey);

            var sp = activeKey.Split('|');
            // [computerId] | [UsingDays] | [ActiveDateInUtc]
            var computerId = sp[0];
            //so ngay duoc phep su dung
            var usingDayAccepted = int.Parse(sp[1]);
            var activeDate = DateTime.FromFileTimeUtc(long.Parse(sp[2]));

            var thisComputerId = Program.ComputerId;

            if (computerId != thisComputerId)
            {
                return new LicenseInfo() { Type = LicenseType.Invalid };
            }

            //So ngay da su dung
            var totalUsingDay = (int)(DateTime.Now - activeDate).TotalDays;
            if (totalUsingDay > usingDayAccepted)
            {
                return new LicenseInfo() { Type = LicenseType.Expired };
            }

            return new LicenseInfo()
            {
                UsingDayAccepted = usingDayAccepted,
                Type = LicenseType.Valid,
                ActiveDateInUtc = long.Parse(sp[2]),
                ActiveKey = activeKey
            };
        }
    }
}
