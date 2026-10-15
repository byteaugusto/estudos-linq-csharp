using Aulas_C_;


class Program
{
    static void Main(string[] args)
    {
        List<Usuario> usuarios = new()
{
    new Usuario
    {
        Id = 1,
        Nome = "Carlos",
        Pedidos = new List<Pedidos>
        {
            new Pedidos
            {
                Id = 1,
                Produto = "Notebook",
                Valor = 3500
            },
            new Pedidos
            {
                Id = 3,
                Produto = "Teclado",
                Valor = 300
            },
            new Pedidos
            {
                Id = 6,
                Produto = "Webcam",
                Valor = 500
            },
            new Pedidos
            {
                Id = 8,
                Produto = "Notebook",
                Valor = 4000
            }
        }
    },

    new Usuario
    {
        Id = 2,
        Nome = "Ana",
        Pedidos = new List<Pedidos>
        {
            new Pedidos
            {
                Id = 2,
                Produto = "Mouse",
                Valor = 150
            },
            new Pedidos
            {
                Id = 5,
                Produto = "Headset",
                Valor = 400
            },
            new Pedidos
            {
                Id = 7,
                Produto = "Mouse",
                Valor = 250
            }
        }
    },

    new Usuario
    {
        Id = 3,
        Nome = "Lucas",
        Pedidos = new List<Pedidos>
        {
            new Pedidos
            {
                Id = 4,
                Produto = "Monitor",
                Valor = 1200
            }
        }
    },

    new Usuario
    {
        Id = 4,
        Nome = "Mariana",
        Pedidos = new List<Pedidos>()
    }
};



        var resultado = ObterResumoClientes(usuarios);

        foreach (var cliente in resultado)
        {
            Console.WriteLine(
                $"Nome: {cliente.Nome} | " +
                $"Total gasto: {cliente.TotalGasto:C2} | " +
                $"Média por pedido: {cliente.Media:C2} | " +
                $"Quantidade de pedidos: {cliente.QuantidadeDePedidos} | " +
                $"Categoria: {cliente.Categoria}"
            );
        }
    }
    static List<ResumoCliente> ObterResumoClientes(List<Usuario> usuarios)
    {
        var resultado = usuarios.SelectMany(
    usuario => usuario.Pedidos,
    (usuario, pedido) => new
    {
        nome = usuario.Nome,
        valor = pedido.Valor

    }).GroupBy(pedido => pedido.nome)
       .Select(grupo => new
       {
           nome = grupo.Key,
           totalGasto = grupo.Sum(pedido => pedido.valor),
           media = grupo.Average(pedido => pedido.valor),
           quantidadeDePedidos = grupo.Count()
       }).Where(cliente => cliente.totalGasto > 1000)
          .OrderByDescending(cliente => cliente.totalGasto)
          .Select(usuario => new ResumoCliente
          {
              Nome = usuario.nome,
              TotalGasto = usuario.totalGasto,
              Media = usuario.media,
              QuantidadeDePedidos = usuario.quantidadeDePedidos,
              Categoria = usuario.media >= 2000 ? "Premium" :
                          usuario.media >= 1000 ? "Normal" :
                          "Econômico"
          });
        return resultado.ToList();
    }
}




