using System;

namespace RuralSimples.Classes
{
    class Propriedade
    {
        private int FIDPropriedade;
        private String FAptidao;
        private double FAreaProdutiva;
        private double FAreaReserva;
        private double FAreaTotal;
        private String FCAR;
        private DateTime FDataAquisicao;
        private DateTime FDataVenda;
        private String FEscritura;
        private String FInativa;
        private String FITR;
        private String FLatitude;
        private String FLongitude;
        private String FMotivoVenda;
        private String FNomePropriedade;
        public int IDPropriedade
        {
            get { return FIDPropriedade; }
            set { FIDPropriedade = value; }
        }
        public double AreaProdutiva
        {
            get { return FAreaProdutiva; }
            set { FAreaProdutiva = value; }
        }
        public double AreaReserva
        {
            get { return FAreaReserva; }
            set { FAreaReserva = value; }
        }
        public double AreaTotal
        {
            get { return FAreaTotal; }
            set { FAreaTotal = value; }
        }
        public String Aptidao
        {
            get { return FAptidao; }
            set { FAptidao = value; }
        }
        public String CAR
        {
            get { return FCAR; }
            set { FCAR = value; }
        }
        public DateTime DataAquisicao
        {
            get { return FDataAquisicao; }
            set { FDataAquisicao = value; }
        }
        public DateTime DataVenda
        {
            get { return FDataVenda; }
            set { FDataVenda = value; }
        }
        public String Escritura
        {
            get { return FEscritura; }
            set { FEscritura = value; }
        }
        public String Inativa
        {
            get { return FInativa; }
            set { FInativa = value; }
        }
        public String ITR
        {
            get { return FITR; }
            set { FITR = value; }
        }
        public String Latitude
        {
            get { return FLatitude; }
            set { FLatitude = value; }
        }
        public String Longitude
        {
            get { return FLongitude; }
            set { FLongitude = value; }
        }
        public String MotivoVenda
        {
            get { return FMotivoVenda; }
            set { FMotivoVenda = value; }
        }
        public String NomePropriedade
        {
            get { return FNomePropriedade; }
            set { FNomePropriedade = value; }
        }
        //Construtores
        public Propriedade()
        {
            PreencherClasse(0, "", 0, 0, 0,
                "", new DateTime(1900, 1, 1, 1, 0, 0), new DateTime(1900, 1, 1, 1, 0, 0), "", "", "N", "", "",
                "", ""
            );
        }
        public Propriedade(String aptidao, double area_produtiva, double area_reserva, double area_total, String car, 
            DateTime data_aquisicao, DateTime data_venda, String escritura, String itr, String inativa, String latitude, String longitude,
            String motivo_venda, String nome_propriedade)
        {
            PreencherClasse(0, aptidao, area_produtiva, area_reserva, area_total, car,
             data_aquisicao, data_venda, escritura, itr, inativa, latitude, longitude,
             motivo_venda, nome_propriedade);
        }
        public Propriedade(int id_propriedade, String aptidao, double area_produtiva, double area_reserva, double area_total, String car,
            DateTime data_aquisicao, DateTime data_venda, String escritura, String itr, String inativa, String latitude, String longitude,
            String motivo_venda, String nome_propriedade)
        {
            PreencherClasse(id_propriedade, aptidao, area_produtiva, area_reserva, area_total, car,
             data_aquisicao, data_venda, escritura, itr, inativa, latitude, longitude,
             motivo_venda, nome_propriedade);
        }
        //Métodos
        public void PreencherClasse(int id_propriedade, String aptidao, double area_produtiva, double area_reserva, double area_total, 
            String car, DateTime data_aquisicao, DateTime data_venda, String escritura, String itr, String inativa, String latitude, String longitude,
            String motivo_venda, String nome_propriedade)
        {
            this.IDPropriedade = id_propriedade;
            this.Aptidao = aptidao;
            this.AreaProdutiva = area_produtiva;
            this.AreaReserva = area_reserva;
            this.AreaTotal = area_total;
            this.CAR = car;
            this.DataAquisicao = data_aquisicao;
            this.DataVenda = data_venda;
            this.Escritura = escritura;
            this.ITR = itr;
            this.Inativa = inativa;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.MotivoVenda = motivo_venda;
            this.NomePropriedade = nome_propriedade;
        }
    }
}
