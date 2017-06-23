using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpIntermediateSection1
{
    public class Stopwatch
    {
        #region Members definition
        private DateTime? StartTime { get; set; } = null;
        #endregion Members definition

        #region Constructors definition
        public Stopwatch()
        {

        }

        public Stopwatch(DateTime startTime)
        {
            this.StartTime = startTime;
        }
        #endregion Constructors definition

        #region Methods definition
        public void Start()
        {
            if (this.StartTime == null)
                { this.StartTime = DateTime.Now; }
            else
                { throw new InvalidOperationException("The stopwatch cannot be started when it is already started."); }
        }

        public TimeSpan Stop()
        {
            DateTime? start = this.StartTime;
            if (start == null)
            {
                throw new InvalidOperationException("The stopwatch has not previously been started.");
            }

            this.StartTime = null;
            return (TimeSpan)(DateTime.Now - start);
        }
        #endregion Methods definition
    }
}
