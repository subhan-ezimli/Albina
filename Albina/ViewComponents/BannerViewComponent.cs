using Albina.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albina.ViewComponents
{
    public class BannerViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        
        public BannerViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var collections = _contentRepository.GetShopCollections();
            var model=_mapper.Map<IEnumerable<ShopCollection>, IEnumerable< ShopCollectionViewModel>>(collections);
            return View(model);
        }

    }
}
