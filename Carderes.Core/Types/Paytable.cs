using System;
using System.Collections.Generic;
using System.Text;

namespace Carderes.Core
{
    public class Paytable : IPaytable
    {
        public List<CardFace> CardHierarchy { get; private set; }
        private List<IWinScenario> winScenarios;

        public Paytable()
        {
            winScenarios = new List<IWinScenario>();
        }

        public void SetCardHierarchy(List<CardFace> hierarchy)
        {
            CardHierarchy = hierarchy;
        }

        public void AddScenario(string description, int[] payouts, IEvaluator evaluator)
        {
            winScenarios.Add(new WinScenario(description, payouts, evaluator));
        }
    }
}
