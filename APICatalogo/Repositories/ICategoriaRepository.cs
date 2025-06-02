using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICatalogo.Models;

namespace APICatalogo.Repositories;

public interface ICategoriaRepository
{
    IEnumerable<Categoria> GetCategorias();
    IEnumerable<Categoria> GetCategoriasProdutos();
    Categoria GetCategoria(int id);
    Categoria Create(Categoria categoria);
    Categoria Update(Categoria categoria);
    Categoria Delete(int id);
}