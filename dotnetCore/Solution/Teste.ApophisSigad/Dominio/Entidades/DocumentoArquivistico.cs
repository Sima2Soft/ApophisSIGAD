using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Teste.ApophisSigad.Dominio.Comum.Anotacao;
using Teste.ApophisSigad.Dominio.Comum.Enums;

namespace Teste.ApophisSigad.Dominio.Entidades
{
    /// <summary>
    /// Entidade DocumentoArquivistico
    /// Representa no Mundo Real: Documento Arquivístico
    /// 
    /// É o Documento <see cref="Documento"/> que foi capturado pelo SIGAD, isto é, declarado como
    /// arquivístico e incorporado ao sistema por meio de registro, classificação, arquivamente, etc.
    /// Esta é a entidade mais importante de um SIGAD.
    /// Um Documento Arquivístico <see cref="DocumentoArquivistico"/> é originado de um Documento <see cref="Documento"/>
    /// simples ou composto, ou seja, formado por um ou vários Documentos <see cref="Documento"/>. Sendo assim, um 
    /// Documento Arquivístico <see cref="DocumentoArquivistico"/> também pode ser simples ou composto. Cada Documento
    /// pode, ainda, aparecer em diversos outros Documentos Arquivísticos <see cref="DocumentoArquivistico"/>.
    /// 
    /// Os Documentos Arquivísticos <see cref="DocumentoArquivistico"/> são:  
    /// - Armazenados em um Volume <see cref="Volume"/> de uma Unidade de Arquivamento <see cref="UnidadeDeArquivamento"/>; ou
    /// - Classificados diretamente em alguma Classe <see cref="Classe"/>.
    /// 
    /// Desta forma, cada Documento Arquivístico <see cref="DocumentoArquivistico"/> deve estar relacionado somente
    /// a um Volume <see cref="Volume"/> de uma Unidade de Arquivamento <see cref="UnidadeDeArquivamento"/> ou a uma 
    /// Classe <see cref="Classe"/>
    /// </summary>
        
    public class DocumentoArquivistico : Documento
    {
        #region Atributos

        #endregion

        #region Construtores

        #endregion

        #region Propriedades

        /// <summary>
        /// Identificador do Documento
        /// </summary>
        [FichaIndividual("Identificador	do	documento",
        "Identificador	único atribuído ao documento no ato de sua	captura para o SIGAD.",
        "Identificar de forma unívoca o documento para que o SIGAD possa	gerenciá-lo.",
        ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
        "Aplicável no âmbito do SIGAD. Pode    ser um  elemento    identificador   simples e   conter  um " +
        "componente para localização em ambiente eletrônico. Deve, preferencialmente, ser gerado de forma " +
        "automática pelo SIGAD. Esse    identificador   tem de  ser unívoco e   persistente.As  instituições " +
        "devem   seguir  normas  específicas em  seu âmbito  de  atuação ou esfera de competência",null,
        "1.6.2 / 3.1.5 / 3.1.7 / 3.1.9 / 5.2.6 / 6.8.3")]
        public virtual Nullable<long> DocumentoId { get; set; }

        /// <summary>
        /// Número do Documento
        /// </summary>
        [FichaIndividual("Número do documento",
        "Número ou código alfanumérico atribuído ao documento no ato de sua produção",
        "Permitir    a   identificação   precisa de  um  documento.",
        ValoresDeObrigatoriedade.NaoSeAplica,
        ValoresDeObrigatoriedade.NaoSeAplica,
        ValoresDeObrigatoriedade.ObrigatorioSeAplicavel,
        "Pode ser acrescido da data de produção e da sigla do órgão produtor",
        "Mem.119/COAD/DIRHU; " +
        "Ofício n. 78 / 2008 / GABIN - NA; " +
        "Aviso 123 / 2008 - SCT - PR.",
        "3.1.10")]
        public virtual String NumeroDoDocumento { get; set; }

        [FichaIndividual("Número do protocolo",
        "Número ou código alfanumérico atribuído ao documento no ato do protocolo.",
        "Permitir	a	identificação	e	o	controle	da	tramitação	do	documento.",
        ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.ObrigatorioSeAplicavel,
        "Pode ser acrescido da data de registro." +
        "Os  órgãos  e   entidades   devem   seguir  normas  específicas em  seu âmbito  de " +
        "atuação ou esfera de competência. " +
        "Esse número deve estar disponível para o usuário.",
        "Carta: AB / 11.000 / 2008; " +
        "Processo n. 0400.001412 / 2000 - 26.",
        "3.1.10")]
        public virtual String NumeroDoProtocolo { get; set; }

        [FichaIndividual(
        "Tipo de meio",
        "Identificação do meio do documento/volume/processo/dossiê:	digital, não digital ou híbrido.",
        "Identificar	se	o	documento/volume/processo/dossiê	é	digital,	não	digital	ou	híbrido " +
        "para controlar as relações entre os meios e o monitoramento de preservação.",
        ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.Obrigatorio, ValoresDeObrigatoriedade.Obrigatorio,
        "No documento/volume/processo/dossiê híbrido, os relacionamentos deverão ser registrados para identificar " +
        "a parte não digital e a parte digital." +
        "Ver elemento 1.1.28 – Relação com outros documentos.",
        null,
        "1.6.1 / 1.6.2 / 3.4 / 4.3.13"
        )]
        public virtual TipoDeMeio TipoDeMeio { get; private set; }

        [FichaIndividual(
            "Status",
            "Indicação do grau de formalização do documento: " +
            "• minuta / rascunho(pré - original): versão preliminar do documento; " +
            "• original: primeiro documento completo e efetivo; " +
            "• cópia: resultado da reprodução do documento.",
            "Identificar o grau de formalização do documento e as relações existentes entre os originais, " +
            "as minutas e as cópias. " +
           "Manter um controle sobre a disposição de cópias.",
            ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "Deverá haver relacionamento entre os vários graus de formalização dos documentos. " +
            "A organização deverá ter um plano de organização e registro do statusdos docu - mentos " +
            "e da forma de relacioná - los.",
            null,
            "2.2.1")]
        public virtual GrauDeFormalizacao Status { get; set; }

        [FichaIndividual(
            "Título",
            "Elemento de descrição que nomeia o documento ou processo / dossiê.Pode ser " +
            "formal ou atribuído: " +
            "• formal: designação registrada no documento; " +
            "•  atribuído: designação  providenciada   para    identificação   de  um  documento " +
            "formalmente desprovido de título.",
            "Identificar	o	documento. Servir como elemento de acesso ao documento.",
            ValoresDeObrigatoriedade.Facultativo,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "Cada instituição deverá fixar critérios para títulos	atribuídos.",
            "Processo de Aquisição de Equipamentos de Informática; " +
            "Balancete da Universidade ACD 2007.",
            "1.6.2 / 3.1.5 / 5.2.6")]
        public virtual String Titulo { get; set; }

        [FichaIndividual(
            "Descrição",
            "Exposição concisa do conteúdo do documento, processo ou dossiê.",
            "Identificar o conteúdo	do documento."+
            "Facilitar a pesquisa.",
            ValoresDeObrigatoriedade.Facultativo,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Facultativo,
            "Cada instituição deverá fixar critérios e modelos com elementos básicos para a " +
            "elaboração da descrição.",
            "Convênio de cooperação para desenvolvimento de aplicações do laser entre a " +
            "Instituição A e a Instituição B, com recursos do Programa Nacional ABC.",
            "3.1.5 / 3.1.11")]
        public virtual String Descricao { get; set; }

        [FichaIndividual(
            "Assunto",
            "Palavras-chave que representam o conteúdo do documento. " +
            "Pode ser de preenchimento livre ou com o uso de vocabulário controlado ou tesauro. " +
            "Diferente	do	já  estabelecido    no  código  de  classificação.",
            "Referir de forma sucinta o teor geral do documento.",
            ValoresDeObrigatoriedade.Facultativo,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Facultativo,
            "As	instituições	devem	definir	sua	política	de	indexação.",
            null,
            "3.1.5 / 3.1.11 / 3.2.11 / 5.2.6"
            )]
        public virtual String Assunto { get; set; }

        [FichaIndividual(
            "Autor",
            "Pessoa física ou jurídica com autoridade para emitir o documento e em cujo nome " +
            "ou sob cuja ordem ou responsabilidade o documento é emitido.",
            "Identificar	o	autor	do	documento." +
            "Fornecer informação sobre o contexto de produção do documento. " +
            "Demonstrar a autenticidade de um documento, indicando o responsável direto " +
            "pela sua produção.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "Registrar informações tais como: nome, cargo, endereço, contato. " +
            "As instituições devem estabelecer normas para controlar as entradas de nomes.",
            "Santos, José ou José Santos",
            "3.1.5 / 5.2.6")]
        public virtual Autoria Autor { get; set; }

        [FichaIndividual(
            "Destinatário",
            "Pessoa física e/ou jurídica a quem foi dirigida a informação contida no documento. " +
            "Pode ser nominal ou geral: " +
            "• nominal: pessoas específicas; " +
            "• geral: refere - se a uma entidade maior, indeterminada.Ex.: cidadãos, povo, " +
            " estudantes, a quem possa interessar, a todos os envolvidos.",
            "Identificar	o	destinatário	do	documento. " +
            "Fornecer informação sobre o contexto de produção do documento. " +
            "Demonstrar a autenticidade de um documento, indicando a quem ele é dirigido. ",
            ValoresDeObrigatoriedade.Facultativo,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "Registrar informações tais como: nome, cargo, endereço, contato. " + 
            "As instituições devem estabelecer normas para controlar as entradas de nomes.",
            null,
            "3.1.5"
            )]
        public virtual String Destinatario { get; set; }

        [FichaIndividual(
            "Originador",
            "Pessoa física ou jurídica designada no endereço eletrônico ou login em que o "+
            "documento é gerado e / ou enviado.",
            "Identificar	o	originador	do	documento." +
            "Fornecer informação sobre o contexto de produção do documento. " +
            "Demonstrar a autenticidade de um documento, indicando o responsável legal pela " +
            "sua emissão.",
            ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "Aplica-se quando o nome do originador for diferente do nome do autor ou do redator.",
            null,
            "3.1.5 / 5.2.6"
            )]
        public virtual String Originador { get; set; }

        [FichaIndividual(
            "Redator",
            "Responsável pela elaboração do conteúdo do documento. ",
            "Identificar	o	redator	do	documento. " +
            "Fornecer informação sobre o contexto de produção do documento. " +
            "Demonstrar a autenticidade de um documento, indicando o responsável pela " +
            "articulação de seu conteúdo.",
            ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "Aplica-se quando o nome do originador for diferente do nome do autor ou do redator.",
            null,
            "3.1.5 / 5.2.6"
            )]
        public virtual String Redator { get; set; }

        [FichaIndividual(
            "Interessado",
            "Nome	e/ou	identificação	da	pessoa	física	ou	jurídica	que	tem	envolvimento " + 
            "ou a quem interessa o assunto do documento.",
            "Facilitar a pesquisa",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,
            "As instituições devem controlar a forma de entrada dos nomes. " +
            "O   interessado pode    ser qualificado como, por exemplo: réu, vítima, inventariante, " +
            "inventariado, apelante, apelado, requerente, solicitante. " +
            " Pode - se fazer o cadastro de interessados internos da organização por categorias " +
            " para    facilitar   o   registro    automático, com dados   de  identificação.Ex.:	número  de " +
            " matrícula, nome, documento   de  identificação",
            "José da Silva;" +
            "987.745.465 - 73(CPF);" +
            "59873 / 0001 - 38(CNPJ);" +
            "8783000238(número de matrícula).",
            "3.1.6 / 5.2.6"
            )]
        public virtual String Interessado { get; set; }

        [FichaIndividual(
            "Procedência",
            "Origem do registro do documento, isto é, instituição legitimamente respon " +
            "sável pela autuação e/ou registro do processo/dossiê.",
            "Apoia a administração das unidades de protocolo e outras unidades de registro arquivístico. " +
            " Apoia a presunção de autenticidade de um documento, indicando a procedência " +
            " do seu registro. facilitar a pesquisa.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.ObrigatorioSeAplicavel,
            "Pode-se fazer o cadastro de procedências de organismos internos à instituição, " +
            "para facilitar a automatização desse elemento, tais como: nome, sigla, número " +
            "correspondente numa tabela de órgãos etc",
            "Ministério da Educação – Gabinete do Ministro. " +
            "Fundação ABCD.",
            "1.5.3 / 3.1.6 / 5.2.6"
            )]
        public virtual String Procedencia { get; set; }

        [FichaIndividual(
            "Gênero",
            "Indica	o	gênero	documental,	ou	seja,	a	configuração	da	informação	no " +
            " documento de acordo com o sistema de signos utilizado na comunicação " +
            " do documento.",
            "Monitorar	os	diversos	gêneros	documentais	de	um	acervo	para	fins	de	gestão " +
            " arquivística. " +
            "Facilitar a pesquisa.",
            ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Facultativo,
            "É necessário que a instituição elabore uma tabela com os gêneros e suas " +
            " designações, para facilitar sua indicação no registro.",
            "Audiovisual; textual; cartográfico; iconográfico; multimídia.",
            "3.1.5"
            )]
        public virtual  String Genero { get; set; }

        [FichaIndividual(
            "Espécie",
            "Indica	a	espécie	documental,	ou	seja,	a	configuração	da	informação	no	docu " +
            "mento de acordo com a disposição e a natureza das informações nele contidas.",
            "Complementar	a	descrição	do	documento	ou	a	identificação	de	título. " +
            "Facilitar a pesquisa",
            ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.NaoSeAplica, ValoresDeObrigatoriedade.Facultativo,
            "As instituições podem preparar, como instrumento complementar de gestão, glossários " +
            "de espécies de documentos que são produzidos no cumprimento de suas funções e " +
            " atividades.A existência de tabelas pode facilitar o registro desse elemento. " +
            "Relaciona - se com tipo documental, descrição e título.",
            "Processo; ofício; ata; relatório; projeto; prontuário.",
            "3.1.5"
            )]
        public virtual String Especie { get; set; }

        [FichaIndividual(
            "Tipo",
            "Indica	o	tipo	documental,	ou	seja,	a	configuração	da	espécie	documental	de " +
            "acordo com a atividade que a gerou.",
            "Complementar	a	descrição	do	documento	ou	a	identificação	do	título. " +
            "Permite a pesquisa limitada a um determinado tipo.",
            ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Facultativo,
            "Há instituições que preparam, como instrumento complementar de gestão de " +
            " seus documentos, glossários de tipos documentais que são produzidos no cum - primento de suas funções e atividades.A existência dessas tabelas pode facilitar " +
            " o registro desse elemento. " +
            "Relaciona - se com espécie documental.",
            "Relatório de pesquisa; carta precatória; ofício-circular; prontuário médico; pron-tuário de funcionário.",
            "3.1.5"
            )]
        public virtual String Tipo { get; set; }

        [FichaIndividual(
            "Idioma",
            "Idioma(s) em que é expresso o conteúdo do documento.",
            "Identificar	o(s)	idioma(s)	do	conteúdo	do	documento. " +
            "Permitir a pesquisa limitada a um determinado idioma.",
            ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Facultativo,
            "As	instituições	devem,	preferencialmente,	utilizar	padrões	para	identificar	idiomas, " +
            "como, por exemplo, a norma ISO 639 - 2 / RA(Codes for the representation of names " +
            "of languages – Part 2: alpha - 3 code).",
            null,
            null
            )]
        public virtual String Idioma { get; set; }

        [FichaIndividual(
            "Quantidade de folhas/páginas",
            "Indicação da quantidade de folhas/páginas de um documento.",
            "Permitir o controle de folhas ou páginas por processo e por volume. "+
            "Facilitar   o   registro    e   o   acesso  a   um  documento   específico " +
            " dentro	do	processo    ou  dossiê.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.Facultativo,
            "Usado para gerenciamento de processos convencionais, que limitam a quantidade " +
            " de folhas, sugerindo a abertura de volumes. " +
            " As instituições devem determinar as normas para esse tipo de ação.",
            null,
            "1.4.3 / Ver seção 1.5 –Volumes: abertura, encerramento e metadados"
            )]
        public virtual Nullable<long> QuantidadeDeFolhasOuPaginas { get; set; }
                
        [FichaIndividual(
            "Numeração sequencial dos documentos",
            "Numeração sequencial dos documentos inseridos em um processo.",
            "Ordenar os documentos em um processo. " +
            "Controlar a integridade do processo. " +
            "Facilitar   a   referência  a   um  documento   específico.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,
            "Usado para processos e dossiês digitais. " +
            "Devem - se numerar os documentos na ordem em que são inseridos no processo a " +
            "fim de  garantir    sua integridade.",
            null,
            "1.4.3"
            )]
        public virtual Nullable<long> NumeracaoSequencial { get; set; }

        [FichaIndividual(
            "Indicação de anexos",
            "Indica se o documento tem anexos.",
            "Registrar a existência de anexos de um determinado documento para apoiar o " +
            "controle de sua integridade e facilitar o acesso.",
            ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            null,
            null,    
            "3.15"
            )]
        public virtual Boolean TemAnexo { get; set; }

        [FichaIndividual(
            "Data de produção",
            "Registro cronológico (data e hora) e tópico (local) da produção do documento.",
            "Indicar local e data em que foi produzido o documento.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            null,
            null,
            "1.3.1 / 3.1.5 / 3.3.1 / 5.2.6"
            )]
        public virtual Nullable<DateTime> DataDeProducao { get; set; }

        [FichaIndividual(
            "Destinação prevista",
            "Indicação da próxima ação de destinação (transferência, eliminação ou " +
            "recolhimento) prevista para o documento, em cumprimento à tabela de " +
            "temporalidade.",
            "Apoiar o controle do ciclo de vida do documento.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "Para a finalidade deste instrumento, considera-se a transferência como uma	ação de destinação. " +
            " As instituições devem estabelecer uma tabela de temporalidade associada ao plano " +
            " de  classificação   para    aplicar este    elemento. " +
            "Este elemento está relacionado ao 1.33",
            null,
            "1.5.3 / 4.1.2 / 4.2.4"
            )]
        public virtual String DestinacaoPrevista { get; set; }

        [FichaIndividual(
            "Localização",
            "Local de armazenamento atual do documento. " +
            "Pode ser um lugar(depósito, estante, repositório digital) ou uma notação física.",
            "Permitir a localização dos documentos em qualquer mídia. " +
            "Monitorar o armazenamento de documentos",
            ValoresDeObrigatoriedade.ObrigatorioSeAplicavel,ValoresDeObrigatoriedade.Facultativo,ValoresDeObrigatoriedade.ObrigatorioSeAplicavel,
            "Deve ser utilizado, obrigatoriamente, quando o documento não se encontra no " +
            "sistema de gestão arquivística de documentos, e é mantido em outra área de " +
            "armazenamento, seja virtual ou física. " +
            "Utilizado apenas para os documentos não digitais, para a parte não digital dos " +
            "documentos híbridos ou para os documentos digitais off-line. " +
            "No caso de documentos digitais on-line, este controle é feito com relação aos " +
            "componentes digitais.Ver metadado 5.5.",
            "Depósito 201, estante 8, prateleira 2; " +
            "Caixa 3456; " +
            "Centro de documentação do IFP, repositório alfa; " +
            "Notação XY.2540.",
            "1.6.1 / 1.6.3 / 1.6.4 / 1.6.7 / 3.1.5 / 3.4.1 / 3.4.2 / 6.8.3"
            )]
        public virtual String Localizacao { get; set; }

        [FichaIndividual(
            "Relação com outros documentos",
            "Registro	das	relações	significantes	de	um	documento	com	outros.	Estas " +
            "relações podem ser entre: " +
            "• documentos diferentes que estão relacionados por registrarem a mesma " +
            "atividade, pessoa ou situação; " +
            "• diferentes níveis de agregação(dossiê, volume e documento); " +
            "• diferentes manifestações do mesmo documento.Ex.: formatos HyperText " +
            "Markup Language(HTML), Open Documet Format(ODF), Portable " +
            "Document Format(PDF / A) ou mesmo em papel",
            "Tornar explícito o relacionamento e facilitar o processamento automático e o " +
            "gerenciamento arquivístico. " +
            "Demonstrar a organicidade dos documentos. " +
            "Facilitar a pesquisa de informações de documentos relacionados.",
            ValoresDeObrigatoriedade.ObrigatorioSeAplicavel,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.ObrigatorioSeAplicavel,
            "As instituições devem estabelecer os tipos de relacionamentos que deverão ser " + 
            "controlados e suas restrições ou condições.Estas relações podem ser expressas " +
            "das seguintes formas: " +
            "• tem parte de, é parte de(relaciona os níveis de agregação); " + 
            "• referenciado ou ver também; " +
            "• tem extrato, é extrato de; " +
            "• é manifestação de; " +
            "• ligação para parte em papel(dossiê híbrido). ",
            null,
            "3.1.5 / 3.1.10 / 3.4 / 11.1.21"
            )]
        public virtual IList<Documento> Documentos{ get; private set; }

        [FichaIndividual(
            "Classe",
            "Identificação	 da	 classe o documento com base em um plano de classificação.",
            "Identificar	a	localização	intelectual	do	documento	no	âmbito	da	estrutura	orgânica " +
            "ou funcional.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "As	instituições	devem	estabelecer	um	plano	de	classificação	para	aplicar	esse	elemento. " +
            "Pode - se registrar o código e / ou o nome completo da classe em que o documento " +
            " está    classificado.",
            null,
            "1.2.1 / 1.5.3 / 3.1.5 / 3.1.10 / 5.2.6"
            )]
        public virtual Classe Classe { get; private set; }
        public virtual Volume Volume { get; private set; }
        public virtual IList<ComponenteDigital> ComponentesDigitais { get; private set; }
        public virtual IList<DocumentoArquivistico> OutrosDocumentos { get; set; }

        [FichaIndividual(
            "Níveis de acesso",
            "Indicação	dos	níveis	de	acesso	ao	documento	a	partir	da	classificação	da " +
            "informação quanto ao grau de sigilo e restrição de acesso.",
            "Garantir o acesso somente a pessoas autorizadas.",
            ValoresDeObrigatoriedade.Obrigatorio,ValoresDeObrigatoriedade.NaoSeAplica,ValoresDeObrigatoriedade.Obrigatorio,
            "As	instituições	devem	estabelecer	as	normas	para	a	classificação	de	sigilo	de " +
            "acordo com suas necessidades ou com base na legislação. " + 
            "Relaciona - se    com tabela  de  classificação   de  segurança.",
            null,
            "3.1.5 / 6.3.1"
            )]
        public virtual IList<NivelDeAcesso> NiveisDeAcesso { get; set; }
        public virtual IList<Versao> Versoes { get; private set; }

        #endregion

        #region Métodos

        #endregion

        #region Sobrescritas do Papai
        /// <summary>
        /// Provê igualdade entre classes de mesmo tipo de DocumentoArquivistico
        /// </summary>
        /// <param name="o">Objeto a ser verificada a igualdade</param>
        /// <returns>true => se for igual e false => se for diferente</returns>			
        public override bool Equals(object o)
        {
            if (o.GetType().IsAssignableFrom(GetType()))
            {
                BindingFlags visibilidadePermitida = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
                FieldInfo[] classeLocal = typeof(DocumentoArquivistico).GetFields(visibilidadePermitida);
                FieldInfo[] classeExterna = o.GetType().GetFields(visibilidadePermitida);

                int totalDeCamposLocais = classeLocal.Select(cl => cl.GetValue(this)).ToList().Count;
                int totalDeCamposExternos = classeExterna.Select(ce => ce.GetValue(this)).ToList().Count;

                var atributos = typeof(DominioTeste).GetFields(visibilidadePermitida).Select(u => u.GetValue(this)).ToList();

                if ((classeLocal != null && totalDeCamposLocais > 0) && classeExterna != null && totalDeCamposExternos > 0)
                {

                    var igualdade = (from l in classeLocal
                                     from e in classeExterna
                                     where l.Name == e.Name && l.GetValue(this) == e.GetValue(this)
                                     select l).ToList();

                    if (igualdade != null && igualdade.Count.Equals(totalDeCamposLocais))
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// A hash code is a numeric value that is used to insert and identify an object in a hash-based collection
        /// such as the Dictionary<TKey, TValue> class, the Hashtable class,or a type derived from the DictionaryBase class.
        /// Two objects that are equal return hash codes that are equal.
        /// </summary>
        /// <returns>O valor do hash gerado ou 0 para a Classe DocumentoArquivistico</returns>
        public override int GetHashCode()
        {
            BindingFlags visibilidadePermitida = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

            int resultado = new Random().Next(0, DateTime.Now.Hour);

            //Pega os Atributos da Classe            
            FieldInfo[] atributos = GetType().GetFields(visibilidadePermitida);

            foreach (FieldInfo atributo in atributos)
            {
                //Calcula de acordo com o tipo e o valor do campo
                switch (atributo.FieldType.Name)
                {
                    case "Boolean":
                        resultado = 31 * resultado + (bool.Parse(atributo.GetValue(this).ToString()) ? 1 : 0);
                        break;
                    case "Byte":
                        resultado = 31 * resultado + Convert.ToInt16((byte.Parse(atributo.GetValue(this).ToString())));
                        break;
                    /*case "char":
                        resultado = 31 * resultado + (char.Parse(atributo.GetValue(this).ToString()));
                        break;
                    */
                    case "Short":
                        resultado = 31 * resultado + (short.Parse(atributo.GetValue(this).ToString()));
                        break;
                    case "Int":
                        resultado = 31 * resultado + (int.Parse(atributo.GetValue(this).ToString()));
                        break;
                    case "Long":
                        resultado = 31 * resultado + int.Parse(atributo.GetValue(this).ToString()) ^ (int.Parse(atributo.GetValue(this).ToString()) >> 32);
                        break;
                    case "Float":
                        resultado = 31 * resultado + Convert.ToInt16(atributo.GetValue(this));
                        break;
                    case "Double":
                        resultado = 31 * resultado + Convert.ToInt16(double.Parse(atributo.GetValue(this).ToString())) ^ (Convert.ToInt16(double.Parse(atributo.GetValue(this).ToString())) >> 32);
                        break;
                }

                switch (atributo.FieldType.FullName)
                {
                    case "System.Nullable`1[System.Int64]":
                        resultado = 31 * resultado + (int.Parse(atributo.GetValue(this).ToString()));
                        break;

                    case "System.Nullable`1[System.Int32]":
                        resultado = 31 * resultado + int.Parse(atributo.GetValue(this).ToString()) ^ (int.Parse(atributo.GetValue(this).ToString()) >> 32);
                        break;
                }
            }
            //// Objects

            //resultado = 31 * resultado + Arrays.hashCode(arrayField);              // var bits » 32-bit

            //resultado = 31 * resultado + referenceField.hashCode();                // var bits » 32-bit (non-nullable)   
            //resultado = 31 * resultado +                                           // var bits » 32-bit (nullable)   
            //    (nullableReferenceField == null
            //        ? 0
            //        : nullableReferenceField.hashCode());

            //return resultado;
            return resultado;
        }

        /// <summary>
        /// Mostra a saída formatada dos valores presentes
        /// nos atributos de DocumentoArquivistico
        /// </summary>
        /// <returns>Uma string contendo os valores dos atributos da Classe Incluindo seus relacionamentos</returns>
        public override string ToString()
        {
            BindingFlags visibilidadePermitida = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
            StringBuilder builder = new StringBuilder();

            //Pega os Atributos da Classe            
            FieldInfo[] atributos = GetType().GetFields(visibilidadePermitida);
            builder.Append("[ ");
            foreach (FieldInfo campo in atributos)
            {
                builder.Append(String.Format("{0} => {1} ", campo.Name, campo.GetValue(this)));
            }

            builder.Append(" ] ");
            return !String.IsNullOrEmpty(builder.ToString()) ? builder.ToString() : String.Empty;
        }
        #endregion

    }
}
