using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Button
    {
        public delegate void ClickHandler();
        public event ClickHandler OnClick;
        public void Click()
        {
            OnClick?.Invoke();
        }
    }
}
