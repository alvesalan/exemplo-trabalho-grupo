using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSistemaComForWhileVetor
{
    class Sistema
    {
        Barco barco = new Barco();

        public Sistema()
        {
            GerirMenu();
        }
        //Apresentar o manu para o usuario
        public void menu()
        {
            Console.WriteLine(
@"\n1-Cadastro de Barco
2-Editar Berco
3-Lista Barco
4-buscar Barco
20-sair");
        }
        public void GerirMenu()
        {


            {

                menu();
                int menuEscolha = Convert.ToInt32(Console.ReadLine());
                while (menuEscolha != 20)
                {
                    switch (menuEscolha)
                    {
                        case 1:
                            barco.CadastrarBarco();
                            break;
                        case 2:
                            barco.EditarBarco();
                            break;
                        case 3:
                            barco.ListarBarco();
                            break;
                        case 4:
                            barco.BuscarBarco();
                            break;
                    }
                    menu();
                    menuEscolha = Convert.ToInt32(Console.ReadLine());

                }

            }

        }
    }
}
