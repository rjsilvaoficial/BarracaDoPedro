﻿using BarracaDoPedro.Models;
using BarracaDoPedro.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarracaDoPedro.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IProdutoRepository produtoRepository, CarrinhoCompra carrinhoCompra)
        {
            _produtoRepository = produtoRepository;
            _carrinhoCompra = carrinhoCompra;

        }
        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = itens;

            var carrinhoCompraViewModel = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()

            };
            return View(carrinhoCompraViewModel);
        }

        public RedirectToActionResult AdicionarItemCarrinhoCompra(int produtoId)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (produtoSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(produtoSelecionado);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoverItemCarrinhoCompra(int produtoId)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (produtoSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(produtoSelecionado,1);
            }

            return RedirectToAction("Index");
        }

    }
}
