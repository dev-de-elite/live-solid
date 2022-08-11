namespace SOLID.Console._4_ISP.Violacao;

public interface ICadastro
{
    void ValidarDados();
    void Salvar();
    void EnviarEmail();
}
