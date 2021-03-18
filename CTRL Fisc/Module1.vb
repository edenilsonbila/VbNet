Imports System.Data.OleDb
Module Module1
    Public conecta As New OleDbConnection
    Public comando As New OleDbCommand
    Public dtset As New DataSet
    Public dataadpt As New OleDbDataAdapter

    Public excluirsuce As String
    Public nameimg As String
    Public Escolher As New OpenFileDialog
    Public escolha As String
    Public coddistrito As String

    Public Sub conectar()
        Try
            conecta.Close()
            conecta.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= fiscdb.accdb;")
            conecta.Open()
            comando.Connection = conecta
        Catch ex As Exception
            MsgBox("Não foi possivel conectar-se a base de dados, Verifique se possui Access instalado", MsgBoxStyle.Critical, "Erro")
        End Try
        
    End Sub

    Public Sub selecionarimagem()
        'Declara Variaveis
        'Padroniza FileDialog
        With Escolher
            .Filter = "Ficheiros Imagem (*.jpg,*.jpeg, *.gif, *.bmp)|*.jpg;*.jpeg;*.gif;*.bmp"
            .FileName = ""
            .Multiselect = False

            'Trata o arquivo selecionado
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                nameimg = (Escolher.FileName)
            End If
        End With
    End Sub

    Public Sub cadastrarfunc()
        Dim uf As String = frmcadastro.cbuf.Text
        Dim inicio As String = frmcadastro.tbinicio.Text
        Dim matricula As String = frmcadastro.tbmatricula.Text
        Dim nascimento As String = frmcadastro.tbnascimento.Text
        Dim nome As String = frmcadastro.tbnome.Text
        Dim numero As String = frmcadastro.tbnumero.Text
        Dim recado As String = frmcadastro.tbrecado.Text
        Dim rg As String = frmcadastro.tbrg.Text
        Dim sexo As String = frmcadastro.tbsexo.Text
        Dim tel As String = frmcadastro.tbtel.Text
        Dim usuario As String = frmcadastro.tbusuario.Text
        Dim bairro As String = frmcadastro.tbbairro.Text
        Dim cel As String = frmcadastro.tbcel.Text
        Dim cep As String = frmcadastro.tbcep.Text
        Dim cidade As String = frmcadastro.tbcidade.Text
        Dim codigo As String = frmcadastro.tbcodigo.Text
        Dim complemento As String = frmcadastro.tbcomplemento.Text
        Dim cpf As String = frmcadastro.tbcpf.Text
        Dim ddd As String = frmcadastro.tbddd.Text
        Dim dddc As String = frmcadastro.tbdddc.Text
        Dim endereco As String = frmcadastro.tbendereco.Text
        Dim email As String = frmcadastro.tbemail.Text
        Dim admissao As String = frmcadastro.tbdta.Text
        Dim rgdv As String = frmcadastro.tbdv.Text
        Dim demissao As String = frmcadastro.tbdtd.Text
        Dim cargo As String = frmcadastro.cbcargo.Text

        If IsNothing(frmcadastro.pb3x4.Image) Then
            MsgBox("Favor selecione uma imagem")
        Else

            Try
                'Copia o arquivo para os diretorios do programa
                Dim nomearquivo As String = Escolher.SafeFileName
                Dim destino As String = "C:\ctrlfisc\Imagem\" & nomearquivo & ""
                FileCopy(nameimg, destino)
            Catch ex As Exception
                MsgBox("Não foi possivel copiar a imagem,Ir em Painel de Controle\Todos os Itens do Painel de Controle\Central de Ações\alterar configurações do controle de contas do usuario Alterar configurações para nunca notificar, Reinicie o micro e tente novamente", MsgBoxStyle.Information, "Erro")
            End Try
            Try
                comando = New OleDbCommand("insert into funcionario (matricula,nome,usuario,cargo,admissao,inicio,demissao,endereco,numero,complemento,bairro,cidade,uf,cep,rg,cpf,sexo,nascimento,telefone,celular,recado,email,imagem) values ('" & matricula & "' , '" & nome & "', '" & usuario & "','" & cargo & "','" & admissao & "','" & inicio & "','" & demissao & "','" & endereco & "','" & numero & "','" & complemento & "','" & bairro & "', '" & cidade & "' , '" & uf & "' , '" & cep & "' , '" & rg & "' , '" & cpf & "' , '" & sexo & "', '" & nascimento & "' , '" & tel & "' , '" & cel & "' , '" & recado & "' , '" & email & "' , '" & nameimg & "')", conecta)
                comando.ExecuteNonQuery()
                MsgBox("Funcionario Cadastrado com Sucesso", MsgBoxStyle.Information, "Sucesso")
                'comando = New OleDbCommand("insert into funcionario (matricula,nome,usuario,cargo,admissao,inicio,demissao,endereco,numero,complemento,bairro,cidade,uf,cep,rg,dv,cpf,sexo,nascimento,dddt,telefone,dddc,celular,recado,email,imagem) values ('" & matricula & "' , '" & nome & "', '" & usuario & "','" & cargo & "','" & admissao & "','" & inicio & "','" & demissao & "','" & endereco & "','" & numero & "','" & complemento & "','" & bairro & "', '" & cidade & "' , '" & uf & "' , '" & cep & "' , '" & rg & "' , '" & rgdv & "' ,'" & cpf & "' , '" & sexo & "', '" & nascimento & "' , '" & ddd & "' ,'" & tel & "' , '" & dddc & "' , '" & cel & "' , '" & recado & "' , '" & email & "' , '" & nameimg & "')", conecta)
                ' comando.ExecuteNonQuery()
                'Limpa os campos
                frmcadastro.cbcargo.Text = ""
                frmcadastro.cbuf.Text = ""
                frmcadastro.tbinicio.Text = ""
                frmcadastro.tbmatricula.Text = ""
                frmcadastro.tbnascimento.Text = ""
                frmcadastro.tbnome.Text = ""
                frmcadastro.tbnumero.Text = ""
                frmcadastro.tbrecado.Text = ""
                frmcadastro.tbrg.Text = ""
                frmcadastro.tbsexo.Text = ""
                frmcadastro.tbtel.Text = ""
                frmcadastro.tbusuario.Text = ""
                frmcadastro.tbbairro.Text = ""
                frmcadastro.tbcel.Text = ""
                frmcadastro.tbcep.Text = ""
                frmcadastro.tbcidade.Text = ""
                frmcadastro.tbcodigo.Text = ""
                frmcadastro.tbcomplemento.Text = ""
                frmcadastro.tbcpf.Text = ""
                frmcadastro.tbddd.Text = ""
                frmcadastro.tbdddc.Text = ""
                frmcadastro.tbdta.Text = ""
                frmcadastro.tbddd.Text = ""
                frmcadastro.tbdv.Text = ""
                frmcadastro.tbendereco.Text = ""
                frmcadastro.tbdtd.Text = ""
                frmcadastro.tbemail.Text = ""
                frmcadastro.pb3x4.Image = Nothing
            Catch ex As Exception
                MsgBox("Impossivel Inserir dados, Verifique o preenchimento dos Campos", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Public Sub pesquisarfunc()
        Dim msg As String
        If escolha = 0 Then
            Dim codigo As Integer = frmcadastro.tbcodigo.Text
            dataadpt = New OleDbDataAdapter("Select * from funcionario where codigo= " & codigo & "", conecta)
            dataadpt.TableMappings.Add("Table", "Dados")
            dataadpt.Fill(dtset)
            msg = "Codigo não cadastrado"
        Else
            Dim matricula As String = frmcadastro.tbmatricula.Text
            dataadpt = New OleDbDataAdapter("Select * from funcionario where matricula= " & matricula & "", conecta)
            dataadpt.TableMappings.Add("Table", "Dados")
            dataadpt.Fill(dtset)
            msg = "Matricula não cadastrada"
        End If

        If dtset.Tables(0).Rows.Count = 0 Then
            MsgBox("" & msg & "", MsgBoxStyle.Information, "Usuario não localizado")

        Else
            frmcadastro.btnexcluir.Enabled = True
            frmcadastro.btnlimpar.Enabled = True
            frmcadastro.pb3x4.ImageLocation = dtset.Tables(0).Rows(0).Item(23)
            frmcadastro.tbcodigo.Text = dtset.Tables(0).Rows(0).Item(0)
            frmcadastro.tbmatricula.Text = dtset.Tables(0).Rows(0).Item(1)
            frmcadastro.tbnome.Text = dtset.Tables(0).Rows(0).Item(2)
            frmcadastro.tbusuario.Text = dtset.Tables(0).Rows(0).Item(3)
            frmcadastro.cbcargo.Text = dtset.Tables(0).Rows(0).Item(4)
            frmcadastro.tbdta.Text = dtset.Tables(0).Rows(0).Item(5)
            frmcadastro.tbinicio.Text = dtset.Tables(0).Rows(0).Item(6)
            frmcadastro.tbdtd.Text = dtset.Tables(0).Rows(0).Item(7)
            frmcadastro.tbendereco.Text = dtset.Tables(0).Rows(0).Item(8)
            frmcadastro.tbnumero.Text = dtset.Tables(0).Rows(0).Item(9)
            frmcadastro.tbcomplemento.Text = dtset.Tables(0).Rows(0).Item(10)
            frmcadastro.tbbairro.Text = dtset.Tables(0).Rows(0).Item(11)
            frmcadastro.tbcidade.Text = dtset.Tables(0).Rows(0).Item(12)
            frmcadastro.cbuf.Text = dtset.Tables(0).Rows(0).Item(13)
            frmcadastro.tbcep.Text = dtset.Tables(0).Rows(0).Item(14)
            frmcadastro.tbrg.Text = dtset.Tables(0).Rows(0).Item(15)
            frmcadastro.tbcpf.Text = dtset.Tables(0).Rows(0).Item(16)
            frmcadastro.tbsexo.Text = dtset.Tables(0).Rows(0).Item(17)
            frmcadastro.tbnascimento.Text = dtset.Tables(0).Rows(0).Item(18)
            frmcadastro.tbtel.Text = dtset.Tables(0).Rows(0).Item(19)
            frmcadastro.tbrecado.Text = dtset.Tables(0).Rows(0).Item(20)
            frmcadastro.tbcel.Text = dtset.Tables(0).Rows(0).Item(21)
            frmcadastro.tbemail.Text = dtset.Tables(0).Rows(0).Item(22)
        End If
        dtset.Clear()
    End Sub

    Public Sub excluirfunc()
        Dim cod As Integer = frmcadastro.tbcodigo.Text
        Dim simnao As String = MsgBox("Deseja realmente excluir este funcionário?", vbYesNo, "Alerta")
        If simnao = vbYes Then
            Try
                comando = New OleDbCommand("delete * from funcionario where codigo= " & cod & "", conecta)
                comando.ExecuteNonQuery()
                MsgBox("Funcionario excluído com sucesso", MsgBoxStyle.Information, "Sucesso")
                excluirsuce = 1
            Catch ex As Exception
                MsgBox("Não foi possivel excluir o funcionario, Verifique a base de dados", MsgBoxStyle.Information, "Sucesso")
                excluirsuce = 0
            End Try
        Else
            excluirsuce = 0
        End If
    End Sub

    Public Sub cadastraronibus()
        Dim prefixo As Integer = frmcdonibus.tbprefixo.Text
        Dim placa As Integer = frmcdonibus.tbplaca.Text
        Dim modelo As String = frmcdonibus.tbmodelo.Text
        Dim poltrona As Integer = frmcdonibus.tbpoltronas.Text
        Dim marca As String = frmcdonibus.tbmarca.Text
        Dim ano As Integer = frmcdonibus.tbano.Text
        Dim chassi As String = frmcdonibus.tbchassi.Text
        Dim tipo As String = frmcdonibus.cbtipo.Text
        Dim acessibilidade As Boolean = frmcdonibus.ckace.CheckState
        Dim ar As Boolean = frmcdonibus.ckar.CheckState
        Dim imagem As String = frmcdonibus.pb1.ImageLocation


        If IsNothing(frmcdonibus.pb1.Image) Then
            MsgBox("Favor selecione uma imagem")
        Else

            Try
                'Copia o arquivo para os diretorios do programa
                Dim nomearquivo As String = Escolher.SafeFileName
                Dim destino As String = "C:\ctrlfisc\Imagem\" & nomearquivo & ""
                FileCopy(nameimg, destino)
            Catch ex As Exception
                MsgBox("Não foi possivel copiar a imagem,Ir em Painel de Controle\Todos os Itens do Painel de Controle\Central de Ações\alterar configurações do controle de contas do usuario Alterar configurações para nunca notificar, Reinicie o micro e tente novamente, Ou verifique se rodou o Install.bat", MsgBoxStyle.Information, "Erro")
            End Try
            Try
                comando = New OleDbCommand("insert into onibus (prefixo,placa,modelo,poltrona,marca,ano,chassi,tipo,acessibilidade,ar,imagem) values ('" & prefixo & "','" & placa & "','" & modelo & "','" & poltrona & "','" & marca & "','" & ano & "','" & chassi & "','" & tipo & "','" & acessibilidade & "','" & ar & "','" & nameimg & "')", conecta)
                comando.ExecuteNonQuery()
                MsgBox("Ônibus Cadastrado com Sucesso", MsgBoxStyle.Information, "Sucesso")
            Catch ex As Exception
                MsgBox("Não foi possivel concluir a operação, Verifique os dados e tente novamente", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Public Sub pesquisaronibus()
        Dim msg As String
        If escolha = 0 Then
            Dim prefixo As Integer = frmcdonibus.tbprefixo.Text
            dataadpt = New OleDbDataAdapter("Select * from onibus where prefixo= " & prefixo & "", conecta)
            dataadpt.TableMappings.Add("Table", "Dados")
            dataadpt.Fill(dtset)
            msg = "Codigo não cadastrado"
        Else
            Dim placa As String = frmcdonibus.tbplaca.Text
            dataadpt = New OleDbDataAdapter("Select * from funcionario where matricula= " & placa & "", conecta)
            dataadpt.TableMappings.Add("Table", "Dados")
            dataadpt.Fill(dtset)
            msg = "Placa não cadastrada"
        End If

        If dtset.Tables(0).Rows.Count = 0 Then
            MsgBox("" & msg & "", MsgBoxStyle.Information, "Usuario não localizado")

        Else
            frmcdonibus.btnexcluir.Enabled = True
            frmcdonibus.btnlimpar.Enabled = True
            frmcdonibus.tbprefixo.Text = dtset.Tables(0).Rows(0).Item(0)
            frmcdonibus.tbplaca.Text = dtset.Tables(0).Rows(0).Item(1)
            frmcdonibus.tbmodelo.Text = dtset.Tables(0).Rows(0).Item(2)
            frmcdonibus.tbpoltronas.Text = dtset.Tables(0).Rows(0).Item(3)
            frmcdonibus.tbmarca.Text = dtset.Tables(0).Rows(0).Item(4)
            frmcdonibus.tbano.Text = dtset.Tables(0).Rows(0).Item(5)
            frmcdonibus.tbchassi.Text = dtset.Tables(0).Rows(0).Item(6)
            frmcdonibus.cbtipo.Text = dtset.Tables(0).Rows(0).Item(7)
            frmcdonibus.ckace.Checked = dtset.Tables(0).Rows(0).Item(8)
            frmcdonibus.ckar.Checked = dtset.Tables(0).Rows(0).Item(9)
            frmcdonibus.pb1.ImageLocation = dtset.Tables(0).Rows(0).Item(10)
        End If
        dtset.Clear()
    End Sub

    Public Sub excluirbus()
        Dim cod As Integer = frmcdonibus.tbprefixo.Text
        Dim placa As String = frmcdonibus.tbplaca.Text
        Dim simnao As String = MsgBox("Deseja realmente excluir este ônibus?", vbYesNo, "Alerta")
        If simnao = vbYes Then
            Try
                comando = New OleDbCommand("delete * from onibus where prefixo= " & cod & "", conecta)
                comando.ExecuteNonQuery()
                MsgBox("Ônibus excluído com sucesso", MsgBoxStyle.Information, "Sucesso")
                excluirsuce = 1
            Catch ex As Exception
                MsgBox("Não foi possivel excluir o funcionario, Verifique a base de dados", MsgBoxStyle.Information, "Sucesso")
                excluirsuce = 0
            End Try
        Else
            excluirsuce = 0
        End If
    End Sub

    Public Sub cadastrarempresa()
        Dim codigo As Integer = frmcadempresa.tbcodigo.Text
        Dim cnpj As String = frmcadempresa.tbcnpj.Text
        Dim razao As String = frmcadempresa.tbrazao.Text
        Dim nome As String = frmcadempresa.tbnomefantasia.Text
        Dim endereco As String = frmcadempresa.tbendereco.Text
        Dim numero As Integer = frmcadempresa.tbnumero.Text
        Dim bairro As String = frmcadempresa.tbbairro.Text
        Dim cidade As String = frmcadempresa.tbcidade.Text
        Dim uf As String = frmcadempresa.cbuf.Text
        Dim complemento As String = frmcadempresa.tbcomplemento.Text
        Dim cep As String = frmcadempresa.tbcep.Text
        Dim ddd As Integer = frmcadempresa.tbddd.Text
        Dim telefone As Integer = frmcadempresa.tbtel.Text

            Try
            comando = New OleDbCommand("insert into empresa (codigo,cnpj,razao,nome,endereco,numero,bairro,cidade,uf,complemento,cep,ddd,tel) values ('" & codigo & "','" & cnpj & "','" & razao & "','" & nome & "','" & endereco & "','" & numero & "','" & bairro & "','" & cidade & "','" & uf & "','" & complemento & "','" & cep & "','" & ddd & "','" & telefone & "')", conecta)
                comando.ExecuteNonQuery()
            MsgBox("Empresa Cadastrada com Sucesso", MsgBoxStyle.Information, "Sucesso")
            Catch ex As Exception
                MsgBox("Não foi possivel concluir a operação, Verifique os dados e tente novamente", MsgBoxStyle.Critical, "Erro")
            End Try
    End Sub

    Public Sub pesquisarempresa()
        Dim msg As String

        If escolha = 0 Then
            Dim codigo As Integer = frmcadempresa.tbcodigo.Text
            dataadpt = New OleDbDataAdapter("Select * from empresa where codigo= " & codigo & "", conecta)
            dataadpt.TableMappings.Add("Table", "Dados")
            dataadpt.Fill(dtset)
            msg = "Codigo não cadastrado"
        Else
            Dim cnpj As String = frmcadempresa.tbcnpj.Text
            dataadpt = New OleDbDataAdapter("Select * from empresa where cnpj= '" & cnpj & "'", conecta)
            dataadpt.TableMappings.Add("Table", "Dados")
            dataadpt.Fill(dtset)
            msg = "Cnpj não cadastrado"
        End If

        If dtset.Tables(0).Rows.Count = 0 Then
            MsgBox("" & msg & "", MsgBoxStyle.Information, "Usuario não localizado")

        Else
            frmcadempresa.btnexcluir.Enabled = True
            frmcadempresa.btnlimpar.Enabled = True
            frmcadempresa.tbcodigo.Text = dtset.Tables(0).Rows(0).Item(0)
            frmcadempresa.tbcnpj.Text = dtset.Tables(0).Rows(0).Item(1)
            frmcadempresa.tbrazao.Text = dtset.Tables(0).Rows(0).Item(2)
            frmcadempresa.tbnomefantasia.Text = dtset.Tables(0).Rows(0).Item(3)
            frmcadempresa.tbendereco.Text = dtset.Tables(0).Rows(0).Item(4)
            frmcadempresa.tbnumero.Text = dtset.Tables(0).Rows(0).Item(5)
            frmcadempresa.tbbairro.Text = dtset.Tables(0).Rows(0).Item(6)
            frmcadempresa.tbcidade.Text = dtset.Tables(0).Rows(0).Item(7)
            frmcadempresa.cbuf.Text = dtset.Tables(0).Rows(0).Item(8)
            frmcadempresa.tbcomplemento.Text = dtset.Tables(0).Rows(0).Item(9)
            frmcadempresa.tbcep.Text = dtset.Tables(0).Rows(0).Item(10)
            frmcadempresa.tbddd.Text = dtset.Tables(0).Rows(0).Item(11)
            frmcadempresa.tbtel.Text = dtset.Tables(0).Rows(0).Item(12)
        End If
        dtset.Clear()
    End Sub

    Public Sub excluirempresa()
        Dim cod As Integer = frmcadempresa.tbcodigo.Text

        Dim simnao As String = MsgBox("Deseja realmente excluir esta empresa?", vbYesNo, "Alerta")
        If simnao = vbYes Then
            Try
                comando = New OleDbCommand("delete * from empresa where codigo= " & cod & "", conecta)
                comando.ExecuteNonQuery()
                MsgBox("Empresa excluída com sucesso", MsgBoxStyle.Information, "Sucesso")
                excluirsuce = 1
            Catch ex As Exception
                MsgBox("Não foi possivel excluir a empresa, Verifique a base de dados", MsgBoxStyle.Information, "Sucesso")
                excluirsuce = 0
            End Try
        Else
            excluirsuce = 0
        End If
    End Sub

    Public Sub caddistrito()
        If frmregiao.tbregiao.Text = "" Then
            MsgBox("Campo região é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
        ElseIf frmregiao.tbcodigo.Text = "" Then
            MsgBox("Codigo é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
        ElseIf frmregiao.tbcodr.Text = "" Or frmregiao.tbcodr.Text = "Cod" Then
            MsgBox("Codigo da região é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
        ElseIf frmregiao.tbnome.Text = "" Then
            MsgBox("Nome da região é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
        Else
            Dim codigo As Integer = frmregiao.tbcodigo.Text
            Dim regiao As String = frmregiao.tbregiao.Text
            Dim cor As String = frmregiao.tbcor.Text
            Dim codr As Integer = frmregiao.tbcodr.Text
            Dim nome As String = frmregiao.tbnome.Text
            Dim conce As String = frmregiao.tbconcessionaria.Text

            Try
                comando = New OleDbCommand("insert into regiao (codigo,regiao,cor,codr,distrito,conce) values ('" & codigo & "', '" & regiao & "', '" & cor & "', '" & codr & "', '" & nome & "', '" & conce & "')", conecta)
                comando.ExecuteNonQuery()
                MsgBox("Distrito cadastado com sucesso", MsgBoxStyle.Information, "Sucesso")
            Catch ex As Exception
                MsgBox("Não foi possivel inserir os dados, Verifique os campos e tente novamente", MsgBoxStyle.Critical, "Erro")
            End Try
                
            End If
    End Sub

    Public Sub cadastrarlinha()
        If frmlinha.tbprefixo.Text = "" Then
            MsgBox("Campo prefixo é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
        ElseIf frmlinha.tbnome.Text = "" Then
            MsgBox("Nome da linha é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
        ElseIf frmlinha.tbregiao.Text = "" Then
            MsgBox("Nome da região é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
        ElseIf frmlinha.cbcodr.Text = "" Then
            MsgBox("Codigo do distrito é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'ElseIf frmlinha.tbnomedis.Text = "" Then
            '  MsgBox("Nome do distrito é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")

        Else
            Dim prefixo As Integer = frmlinha.tbprefixo.Text
            Dim nome As String = frmlinha.tbnome.Text
            Dim regiao As String = frmlinha.tbregiao.Text
            Dim cor As String = frmlinha.tbcor.Text
            Dim codr As String = frmlinha.cbcodr.Text
            'Dim nomedis As String = frmlinha.tbnomedis.Text
            Dim nomelinhas As String = " & prefixo & -nome"
            nomelinhas = "" & prefixo & " - " _
     & nome
            MsgBox(nomelinhas)
            Try
                comando = New OleDbCommand("insert into linha (prefixo,nome_linha,regiao,cor,codr) values ('" & prefixo & "', '" & nomelinhas & "', '" & regiao & "', '" & cor & "', '" & codr & "')", conecta)
                comando.ExecuteNonQuery()
                MsgBox("Linha cadastado com sucesso", MsgBoxStyle.Information, "Sucesso")
            Catch ex As Exception
                MsgBox("Não foi possivel inserir os dados, Verifique os campos e tente novamente", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Public Sub gravarfisc()
        'Linha
        If frmprincipal.cblinha.Text = "" Then
            MsgBox("Linha é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Cobrador
        ElseIf frmprincipal.cbcobrador.Text = "" Then
            MsgBox("Cobrador é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Motorista
        ElseIf frmprincipal.cbmotorista.Text = "" Then
            MsgBox("Motorista é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Fiscal
        ElseIf frmprincipal.cbfiscal.Text = "" Then
            MsgBox("Fiscal é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Onibus
        ElseIf frmprincipal.cbonibus.Text = "" Then
            MsgBox("Onibus é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Saidap
        ElseIf frmprincipal.tbsaida_p.Text = "" Then
            MsgBox("Saída prevista é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Saida
        ElseIf frmprincipal.tbsaida.Text = "" Then
            MsgBox("Saida é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Chegada p
        ElseIf frmprincipal.tbchegada_p.Text = "" Then
            MsgBox("Chegada prevista é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Chegada
        ElseIf frmprincipal.tbchegada.Text = "" Then
            MsgBox("Chegada é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Catraca inicial
        ElseIf frmprincipal.tbcatraca_i.Text = "" Then
            MsgBox("Catraca inicial é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Catraca final
        ElseIf frmprincipal.tbcatraca_f.Text = "" Then
            MsgBox("Catraca final é de preenchimento obrigatório", MsgBoxStyle.Information, "Campo em branco")
            'Total pagantes
        ElseIf frmprincipal.tbtotal_p.Text = "" Then
            MsgBox("Clique no campo total de pagantes para caucular o valor", MsgBoxStyle.Information, "Campo em branco")
            'Total viagem
        ElseIf frmprincipal.tbtotal_v.Text = "" Then
            MsgBox("Clique no campo total Viagem para caucular o valor", MsgBoxStyle.Information, "Campo em branco")


        Else
            Dim linha As String = frmprincipal.cblinha.Text
            Dim fiscal As String = frmprincipal.cbfiscal.Text
            Dim motorista As String = frmprincipal.cbmotorista.Text
            Dim cobrador As String = frmprincipal.cbcobrador.Text
            Dim onibus As String = frmprincipal.cbonibus.Text
            Dim saida_p As String = frmprincipal.tbsaida_p.Text
            Dim saida As String = frmprincipal.tbsaida.Text
            Dim chegada_p As String = frmprincipal.tbchegada_p.Text
            Dim chegada As String = frmprincipal.tbchegada.Text
            Dim catraca_i As String = frmprincipal.tbcatraca_i.Text
            Dim catraca_f As String = frmprincipal.tbcatraca_f.Text
            Dim total_p As String = frmprincipal.tbtotal_p.Text
            Dim total_v As String = frmprincipal.tbtotal_v.Text
            Dim obs As String = frmprincipal.tbobs.Text
            Dim data As DateTime = Date.Today
            MsgBox("Data a ser gravada: " & data)

            Try
                comando = New OleDbCommand("insert into fisc (linha,fiscal,motorista,cobrador,onibus,saida_p,saida,chegada_p,chegada,catraca_i,catraca_f,totalpagantes,totalviagem,obs,data) values ('" & linha & "' , '" & fiscal & "', '" & motorista & "','" & cobrador & "','" & onibus & "','" & saida_p & "','" & saida & "','" & chegada_p & "','" & chegada & "','" & catraca_i & "','" & catraca_f & "', '" & total_p & "' , '" & total_v & "' , '" & obs & "' , '" & data & "')", conecta)
                comando.ExecuteNonQuery()
                MsgBox("Dados da fiscalização cadastados com sucesso", MsgBoxStyle.Information, "Sucesso")
            Catch ex As Exception
                MsgBox("Não foi possivel inserir os dados, Verifique os campos e tente novamente", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Function SoLETRAS(ByVal KeyAscii As Integer) As Integer

        'Transformar letras minusculas em Maiúsculas

        KeyAscii = Asc(UCase(Chr(KeyAscii)))

        ' Intercepta um código ASCII recebido e admite somente letras

        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then

            SoLETRAS = 0

        Else

            SoLETRAS = KeyAscii

        End If



        ' teclas adicionais permitidas

        If KeyAscii = 8 Then SoLETRAS = KeyAscii ' Backspace

        If KeyAscii = 13 Then SoLETRAS = KeyAscii ' Enter

        If KeyAscii = 32 Then SoLETRAS = KeyAscii ' Espace

    End Function

    Function SoNumeros(ByVal Keyascii As Short) As Short

        If InStr("1234567890", Chr(Keyascii)) = 0 Then

            SoNumeros = 0

        Else

            SoNumeros = Keyascii

        End If



        Select Case Keyascii

            Case 8

                SoNumeros = Keyascii

            Case 13

                SoNumeros = Keyascii

            Case 32

                SoNumeros = Keyascii

        End Select

    End Function
End Module
