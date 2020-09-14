using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;

using CluedIn.Crawling.Dynamics365.Vocabularies;
using CluedIn.Crawling.Dynamics365.Core.Models;
using RuleConstants = CluedIn.Core.Constants.Validation.Rules;

namespace CluedIn.Crawling.Dynamics365.ClueProducers
{

    public abstract class DynamicsClueProducer<T> : BaseClueProducer<T>
    {
        public abstract void Customize(Clue clue, T input);
    }

}
