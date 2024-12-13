using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ClimaTempo.Models;
using ClimaTempo.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ClimaTempo.ViewModels
{
    public partial class PrevisaoViewModel : ObservableObject
    {
        
        [ObservableProperty]
        private string cidade;

        [ObservableProperty]
        private string estado;

        [ObservableProperty]
        private DateTime data;

        [ObservableProperty]
        private string condicao;

        [ObservableProperty]
        private double min;

        [ObservableProperty]
        private double max;

        [ObservableProperty]
        private double indice_uv;

        //Dados da Pesquisa de Cidade
        [ObservableProperty]
        private string cidade_pesquisada;

        //Dados da Pesquisa da Previsão por Cidade
        [ObservableProperty]
        private int id_pesquisado;

        [ObservableProperty]
        private List<Clima> proximosDias;
        
        private Previsao previsao;
        private Previsao proxPrevisao;

        [ObservableProperty]
        private List<Cidade> cidades;


        public ICommand BuscarPrevisaoCommand { get; }
        public ICommand BuscarCidadesCommand { get; }

        public PrevisaoViewModel()
        {
            BuscarPrevisaoCommand = new Command<int>(BuscarPrevisao);
            BuscarCidadesCommand = new Command(BuscarCidades);
        }

        public async void BuscarPrevisao(int id)
        {
            //Busca os dados da previsão para uma cidade especificada
            previsao = await new PrevisaoService().GetPrevisaoById(id);
            Cidade = previsao.Cidade;
            Estado = previsao.Estado;
            Data = previsao.clima[0].Data;
            Max = previsao.clima[0].Max;
            Min = previsao.clima[0].Min;
            Condicao = previsao.clima[0].Condicao;
            Indice_uv = previsao.clima[0].Indice_uv;

            //Busca os dados da previsão para os próximos dias
            proxPrevisao = await new PrevisaoService().GetPrevisaoForXDaysById(id, 3);
            ProximosDias = proxPrevisao.clima;
        }

        public async void BuscarCidades()
        {
            Cidades = new List<Cidade>();
            Cidades = await new CidadeService().GetCidadesByName(cidade_pesquisada);
        }
    }
}
