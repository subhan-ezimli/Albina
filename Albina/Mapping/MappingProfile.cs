using Albina.Models;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albina.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<SliderItem, SliderItemViewModel>();
            CreateMap<ShopCollection, ShopCollectionViewModel>();
            CreateMap<Label, LabelViewModel>();
            CreateMap<Discount, DiscountViewModel>();
            CreateMap<Product, ProductViewModel>();
          
        }
    }
}
