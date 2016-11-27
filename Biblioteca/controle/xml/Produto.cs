using System.Xml;
using System.IO;
using Biblioteca.modelo.basicas;
using System;

namespace Biblioteca.controle.xml {
// Observe o namespace, crie um pacote XML dentro de Controller

    public class XMLProduto {
        XmlDocument xml = new XmlDocument();

        string way = @"C:\Users\daniel\Source\Repos\Produto.xml";
        // Coloca na String way, onde quer que seja salvo o arq. XML
        // Ex: C:\Users\ABCD\Desktop\Clinic\Consulta.xml

        private void XML() {
            if (File.Exists(way) == false) {
                XmlNode root = xml.CreateElement("Produto");
                xml.AppendChild(root);
                xml.Save(way);
            }
        }

        public XMLProduto() {
            XML();
        }

        public void insertXML(Produto bProd) {
            int pos = 0;
            xml.Load(way);

            XmlNode row        = xml.CreateElement("ConsultaChild");
            XmlNode codProduto = xml.CreateElement("codProduto");
            XmlNode fornecedor = xml.CreateElement("fornecedor");
            XmlNode produto    = xml.CreateElement("produto");
            XmlNode valor      = xml.CreateElement("valor");
            XmlNode quantidade = xml.CreateElement("quantidade");

            codProduto.InnerText = (bProd.Cod_produto+ "" + 1);
            fornecedor.InnerText = bProd.Fornecedor.RazSocial + "";
            produto.InnerText    = bProd.Nome_prod + "";
            valor.InnerText      = Convert.ToString(bProd.Valor);
            quantidade.InnerText = Convert.ToString(bProd.Qtd_prod);

            row.AppendChild(codProduto);
            row.AppendChild(fornecedor);
            row.AppendChild(produto);
            row.AppendChild(valor);
            row.AppendChild(quantidade);
            xml.SelectSingleNode("/Produto").AppendChild(row);

            xml.Save(way);
            pos++;
        }
    }
}
