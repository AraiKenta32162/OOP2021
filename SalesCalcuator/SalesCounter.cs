using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalcuator {
    //売上集計クラス
    class SalesCounter {
        private List<Sale> _sales;

        //コンストラクタ//ct+(Tab*2)
        public SalesCounter(List<Sale> sales) {
            _sales = sales;
        }
    }
}
