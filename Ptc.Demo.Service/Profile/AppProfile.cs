using Ptc.Demo.Domain.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Service.Profile
{
    public class AppProfile
    {

        public static readonly Lazy<AppProfile> LazyInstance = new Lazy<AppProfile>(() => new AppProfile());

        public static AppProfile Instance { get { return LazyInstance.Value; } }

        public AppProfile()
        {
            this.GoogleMapProfile = GoogleMapProfile.Instance;

        }

        [ProfileSource(IsFromDB = true, IsObject = true)]
        public GoogleMapProfile GoogleMapProfile;
    }
}
