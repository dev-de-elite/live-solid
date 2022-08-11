namespace SOLID.Console._4_ISP.Violacao;

public class CadastroProduto : ICadastro
{
    public void ValidarDados()
    {
        // Validar produto
    }

    public void Salvar()
    {
        // Insert tabela Produto
    }

    public void EnviarEmail()
    {
        // Produto não tem e-mail
        throw new NotImplementedException("Esse metodo não serve pra nada");
    }
}
