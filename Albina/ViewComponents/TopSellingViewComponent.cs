using Albina.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albina.ViewComponents
{
    public class TopSellingViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public TopSellingViewComponent(IMapper mapper,
                                        IProductRepository productRepository)
        {

            _mapper = mapper;
            _productRepository = productRepository;
        }
        public IViewComponentResult Invoke()
        {
            var products = _productRepository.GetTopSellingProduct(8);
            var modele = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return View(modele);
        }

        
    }
}
