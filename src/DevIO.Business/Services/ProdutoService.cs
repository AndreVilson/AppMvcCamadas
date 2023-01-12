using System;
using System.Threading.Tasks;
using AppMvcSimples.Models;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Business.Models.Validations;

namespace DevIO.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
       

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            //await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            //await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
            //await _produtoRepository.Remover(id);
        }

        //public void Dispose()
        //{
        //    _produtoRepository?.Dispose();
        //}
    }
}
