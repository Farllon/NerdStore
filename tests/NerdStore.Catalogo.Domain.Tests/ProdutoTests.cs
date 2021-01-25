using NerdStore.Core.DomainObjects;
using System;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            var ex = Assert.Throws<DomainException>(() =>
                new Produto(string.Empty, "Descricao", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo Nome do produto não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", string.Empty, false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo Descrição do produto não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descicao", false, -1, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo Valor do produto não pode ser menor que zero", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descicao", false, 100, Guid.Empty, DateTime.Now, "Imagem", new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo CategoriaId não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descicao", false, 100, Guid.NewGuid(), DateTime.Now, string.Empty, new Dimensoes(1, 1, 1))
            );

            Assert.Equal("O campo Imagem do produto não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Produto("Nome", "Descicao", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(0, 1, 1))
            );

            Assert.Equal("O campo Altura não pode ser menor ou igual a zero", ex.Message);
        }
    }
}
