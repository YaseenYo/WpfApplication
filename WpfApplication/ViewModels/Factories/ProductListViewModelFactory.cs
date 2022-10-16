﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.Services;

namespace WpfApplication.ViewModels.Factories
{
    internal class ProductListViewModelFactory : IViewModelFactory<ProductListViewModel>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICartRepository _cartRepository;

        public ProductListViewModelFactory(IProductRepository productRepository, ICartRepository cartRepository)
        {
            _productRepository = productRepository;
            _cartRepository = cartRepository;
        }

        public ProductListViewModel CreateViewModel()
        {
            return new ProductListViewModel(_productRepository, _cartRepository);
        }
    }
}
