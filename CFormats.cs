using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimsProject
{
    public class EmptyKgCustomFormatter : IFormatProvider, ICustomFormatter
    {
        #region ICustomFormatter Members
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            decimal? emptyLegTime = arg as decimal?;

            string value = null;

            if (emptyLegTime.HasValue)
            {
                value = string.Format("{0} kg", emptyLegTime);
            }
            else
            {
                value = "0 kg";
            }

            return value;
        }
        #endregion

        #region IFormatProvider Members
        public object GetFormat(Type formatType)
        {
            return this;
        }
        #endregion
    }
}
