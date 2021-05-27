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

        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    //すでにコレクションに店舗が設定されている
                    dict[sale.ShopName] += sale.Amount;
                else
                    //コレクション店舗への評判
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
    }
}