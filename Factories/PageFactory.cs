using BatchProcess.Models;
using BatchProcess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatchProcess.Factories
{
    public class PageFactory
    {
        private readonly Func<ApplicationPageNames, PageViewModelBase> _pageFactory;

        public PageFactory(Func<ApplicationPageNames, PageViewModelBase> pageFactory)
        {
            _pageFactory = pageFactory;
        }

        public PageViewModelBase GetPageViewModel(ApplicationPageNames pageName) => _pageFactory.Invoke(pageName);

    }
}
