using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.ApophisSigad.Dominio.Comum.Anotacao;

namespace Teste.ApophisSigad.Dominio.Agregadas.Documento
{
    /// <summary>
    /// As informações a seguir referem-se a eventos de captura, movimentação e controle do ciclo de vida do documento.    
    /// Para cada evento, são apresentados uma definição e os elementos de metadados que o 
    /// caracterizam e que devem ser registrados.
    /// </summary>
    public interface IEventoDeGestao
    {
        [EventoDeGestao(
            "2.1 Captura",
            "Descreve a captura do documento." +
            "Registrar informações tais como: iden - tificação	do	documento, data / hora   da " +
            " captura, responsável pela captura.",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Obrigatorio,
            "3.1.5 | 3.1.16 | 3.2.1 | 3.3.1 | 3.4.1 | 6.4.1"
            )]
        void Capturar();

        [EventoDeGestao(
            "2.2 Tramitação",
            "Registro da tramitação do documento. " + 
            "Registrar informações tais como: " +
            "identificação	do	documento, data/hora de transmissão, " +
            "remetente, data / hora do recebimento,  destinatário, situação do trâmite.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "3.1.5 | 2.1.20"
            )]
        void Tramitar();

        [EventoDeGestao(
            "2.3 Transferência",
            "Registro de transferência de documentos. " +
            "Registrar informações tais como: data / hora de envio, data / hora de recebimento, " +
            " destinatário, método utilizado, res - ponsável pela transferência, responsável pelo recebimento, " +
            "localização / suporte anterior, localização / suporte atual, " +
            "identificação	do	lote, número	do	termo   de transferência. " +
            "Os sub - elementos registram as infor - mações do evento transferência, e deve " +
            "ser feito um registro para cada lote transferido. " +
            "No metadado do documento pode ser registrado apenas o número do lote de " +
            "transferência",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Obrigatorio,
            "4.1.4 | 6.8.3"
            )]
        void Tranferir();

        [EventoDeGestao(
            "2.4 Recolhimento",
            "Registrar informações tais como: data/hora de envio, data/hora de recebimento, " +
            "destinatário, método utilizado, res - ponsável pelo recolhimento, " +
            "localização / suporte anterior, localização / suporte atual, identificação do lote, " +
            "número do termo de recolhimento.",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Obrigatorio,
            "4.1.4"
            )]
        void Recolher();

        [EventoDeGestao(
            "2.5 Eliminação",
            "Indica se o documento foi eliminado. " +
            "Registrar informações tais como: data/hora do procedimento, " +
            "Responsável, número do termo de eliminação, número " +
            "do edital. ",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Obrigatorio,
            "4.1.4 | 4.4.9"
            )]
        void Eliminar();

        [EventoDeGestao(
            "2.6 Abertura_processo",
            "Registro de abertura de um processo num sistema de gestão arquivística. " +
            "Registrar informações tais como: data / hora da abertura, " +
            "responsável pela abertura." ,
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.3.1 | 4.1.5"
            )]
        void AbrirProcesso();

        [EventoDeGestao(
            "2.6 Abertura_dossiê",
            "Registro de abertura de um Dossiê num sistema de gestão arquivística. " +
            "Registrar informações tais como: data / hora da abertura, " +
            "responsável pela abertura.",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.3.1 | 4.1.5"
            )]
        void AbrirDossie();

        [EventoDeGestao(
            "2.7 Encerramento_processo",
            "Registro do encerramento ou arquivamento de um processo num sistema de gestão arquivística. " +
            "Registrar informações tais como: data / hora do encerramento, responsável.",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.3.1 | 1.4.9"
            )]
        void EncerrarProcesso();

        [EventoDeGestao(
            "2.7 Encerramento_dossiê",
            "Registro do encerramento ou arquivamento de um dossiê num sistema de gestão arquivística. " +
            "Registrar informações tais como: data / hora do encerramento, responsável.",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.3.1 | 1.4.9"
            )]
        void EncerrarDossie();

        [EventoDeGestao(
            "2.8 Reabertura_processo",
            "Registro de reabertura de processo/dossiê. " +
            "Registrar informações tais como: data / hora da reabertura, responsável.",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.4.10"
            )]
        void ReabrirProcesso();

        [EventoDeGestao(
            "2.8 Reabertura_dossiê",
            "Registro de reabertura de dossiê. " +
            "Registrar informações tais como: data / hora da reabertura, responsável.",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.4.10"
            )]
        void ReabrirDossie();

        [EventoDeGestao(
            "2.9 Abertura_volume",
            "Registro de abertura de um volume num sistema de gestão arquivística. " +
            "Registrar informações tais como: data / hora da abertura, responsável pela abertura.",
            ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.5.4 | 1.5.5 | 1.5.8"
            )]
        void AbrirVolume();

        [EventoDeGestao(
            "2.10 Encerramento_volume",
            "Registro do encerramento ou arquiva-mento de um volume num sistema de gestão arquivística. "+
            "Registrar informações tais como: data / hora do encerramento, responsável.",
            ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.5.5 | 1.5.7 | 1.5.8 | 1.5.9"
            )]
        void EncerrarVolume();
        [EventoDeGestao(
            "2.11 Juntada_anexação",
            "Registro	da	juntada,	em	caráter	defini-tivo, de documento ou processo a outro " +
            "processo, na qual prevalece para referên - cia o número do processo mais antigo. " +
            "Registrar informações tais como: data / hora da anexação, responsável pela anexação," +
            "identificador do processo que foi anexado",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.4.5"
            )]
        void JuntadaAnexacao();

        [EventoDeGestao(            
            "2.12 Juntada_apensação",
            "Registro da apensação, ou seja, juntada em caráter temporário, com o objetivo de elucidar ou subsidiar a " +
            "matéria trata - da, conservando cada processo sua iden - tidade ou independência." +
            "Registrar informações tais como: data / hora da apensação, responsável pela " +
            "apensação, identificador do processo que foi apensado.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,
            "1.4.5"
            )]
        void JuntadaApensacao();

        [EventoDeGestao(
            "2.13 Desapensação",
            "Registro da desapensação. " +
            "Registrar informações tais como: data / hora da desapensação, responsável pela " +
            "desapensação, identificador	do	processo que foi desapensado.",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.4.6"
            )]
        void Desapensar();

        [EventoDeGestao(
            "2.14 Desentranhamento",
            "Registro de retirada autorizada de docu-mentos de um processo." +
            "Registrar informações tais como: data / hora do desentranhamento, responsável " +
            "pelo desentranhamento, identificador das peças que foram desentranhadas.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "1.4.7"
            )]
        void Desentranhar();

        [EventoDeGestao(
            "2.15 Desmembramento",
            "Registro de desmembramento de processos." +
            "Registrar informações tais como: data /hora do desmembramento, responsável pelo desmembramento, " +
            "registro dos documentos retirados, identificador do " +
            "novo processo formado com os docu - mentos retirados.",
            ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.NaoSeAplica,
            "1.4.8"
            )]
        void Desmembrar();

        [EventoDeGestao(
            "2.16	Classificação_sigilo",
            "Registro	do	procedimento	de	classifica-ção de sigilo. " +
            "Registrar informações referentes à clas - sificação   de  grau    de  sigilo, tais    como: " +
            "grau    de  sigilo, data / hora   da  classifica - ção, responsável pela    classificação.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "1.6.8 - Ver Seção 6.2"
            )]
        void ClassificarComoSigilo();

        [EventoDeGestao(
            "2.17	Desclassificação_sigilo",
            "Registro	do	procedimento	de	desclassifi-cação de sigilo. " +
            "Registrar informações referentes à des - classificação	do	grau    de  sigilo, tais    como: " +
            "grau    de  sigilo, data / hora   da  desclassifi - cação, responsável pela    desclassificação.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "Ver Seção 6.3"
            )]
        void DesclassificarComoSigilo();

        [EventoDeGestao(
            "2.18 Reclassificação_sigilo",
            "Registro	do	procedimento	de	reclassifi-cação de sigilo." +
            "Registrar informações referentes à re - classificação	do	grau    de  sigilo, tais    como: " +
            "data / hora   da  reclassificação, responsá - vel    pela    reclassificação, justificativa.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "Ver Seção 6.3"
            )]
        void ReclassificarComoSigilo();


    }
}
