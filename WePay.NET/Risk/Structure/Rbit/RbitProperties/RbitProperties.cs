using Newtonsoft.Json;

namespace WePayApi.Risk.Structure.Rbit.RbitProperties
{
    public class RbitProperties
    {
        [JsonIgnore]
        public virtual string RbitType
        {
            get
            {
                return null;
            }
            set
            {
                RbitType = null;
            }
        }
    }
}