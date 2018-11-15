using Ovidio_mvc.Models; //Da ListaCatalogo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ovidio_mvc.Controllers
{
    public class CatalogoController : Controller //
    {
        /*
          IEnumerable (No Index.cshtml): Representa uma lista, pode ser passado um cinjuto d coisas. 
          La vamos passar um Catalogo, nesse Catelogo ter uma lista d Filmes pra exibir na tela. P/ atender essa necessidade vamos
          criar uma lista no "public ActionResult Index()"
         */

        // GET: Catalogo
        public ActionResult Index() /*Qdo solicitar o Controller d Catalogo, vou querer retornar uma lista dos filmes q ja tem. Entao vamos colocar uma View d "Lista" */
        {
            var ListaCatalogo = new List<Catalogo>(); //Foi simplificado criando uma biblioteca "using Ovidio_mvc.Models;"

            var item1 = new Catalogo();
            item1.Titulo = "Mulher Maravilha";
            item1.Sinopse = "O Lorem Ipsum é um texto modelo da indústria tipográfica e de impressão.";
            item1.Duracao = 90;
            item1.AnoLancamento = "2018";
            item1.Director = "John Dipp";
            item1.Imagem = @"/Images/MulherMaravilha.jpg"; //Link da imgem
            ListaCatalogo.Add(item1); //Add na lista

            var item2 = new Catalogo();
            item2.Titulo = "Senhor dos aneis";
            item2.Sinopse = "O Senhor dos Anéis é uma trilogia de livros de alta fantasia escrita pelo escritor britânico J. R. R. Tolkien. Escrita entre 1937 e 1949, com muitas partes criadas durante a Segunda Guerra Mundial, a saga é uma continuação de O Hobbit.";
            item2.Duracao = 110;
            item2.AnoLancamento = "2000";
            item2.Director = "J.R.R. Tolkien";
            item2.Imagem = @"/Images/SenhorDosAnesi.jpg";
            ListaCatalogo.Add(item2); //Add na lista

            var item3 = new Catalogo();
            item3.Titulo = "Game of thrones";
            item3.Sinopse = "Baseada nos livros de George R.R. Martin, a série mostra duas famílias poderosas disputando um jogo mortal pelo controle dos Sete Reinos de Westeros para assumir o Trono de Ferro";
            item3.Duracao = 45;
            item3.AnoLancamento = "2011";
            item3.Director = "George R. Martin";
            item3.Imagem = @"/Images/GameOfThrones.jpg";
            ListaCatalogo.Add(item3); //Add na lista

            var item4 = new Catalogo();
            item4.Titulo = "Douctor Estranho";
            item4.Sinopse = "Após sua carreira ser destruída, um brilhante, porém arrogante, cirurgião ganha uma nova chance em sua vida quando um feiticeiro o treina para se tornar o Mago Supremo.";
            item4.Duracao = 120;
            item4.AnoLancamento = "2016";
            item4.Director = "Stan Lee & Steve Ditko";
            item4.Imagem = @"/Images/DoutorEstranho.jpg";
            ListaCatalogo.Add(item4); //Add na lista

            var item5 = new Catalogo();
            item5.Titulo = "Fast furious 8";
            item5.Sinopse = "Depois que Brian e Mia se aposentaram, e o resto da equipe foi exonerado, Dom e Letty estão em lua de mel e levam uma vida pacata e completamente normal. Mas a adrenalina do passado volta com tudo quando uma mulher misteriosa faz com que Dom retorne ao mundo do crime e da velocidade.";
            item5.Duracao = 150;
            item5.AnoLancamento = "2017";
            item5.Director = "F. Gary Gray";
            item5.Imagem = @"/Images/Velocidade Furiosa8.png";
            ListaCatalogo.Add(item5);

            var item6 = new Catalogo();
            item6.Titulo = "O Lobo de Wall Street";
            item6.Sinopse = "Jordan Belfort é um ambicioso corretor da bolsa de valores que cria um verdadeiro império, enriquecendo de forma rápida, porém ilegal. Ele e seus amigos mergulham em um mundo de excessos, mas seus métodos ilícitos despertam a atenção da polícia.";
            item6.Duracao = 125;
            item6.AnoLancamento = "2014";
            item6.Director = "Martin Scorsese";
            item6.Imagem = @"/Images/LoboDeWallStreet.jpg";
            ListaCatalogo.Add(item6);

            

            //Agora vcamos passar ListaCatalogo na "View" abaixo

            return View(ListaCatalogo); 
            //OBS: Temos acesso a "View" por causa da Heranca d cima public class "CatalogoController : Controller"
            //Ou seja o Controller eh q tras aqui a View
        }

        // GET: Catalogo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Catalogo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catalogo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalogo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Catalogo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalogo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catalogo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
