﻿Public Class EMPLEADOS
    Private Sub cmbDepto_LostFocus(sender As Object, e As EventArgs) Handles cmbDepto.LostFocus
        Dim Departamento As Integer
        Departamento = cmbDepto.SelectedIndex
        Select Case Departamento
            Case 0
                Dim atlantida(7) As String
                atlantida(0) = "La Ceiba"
                atlantida(1) = "El Porvenir"
                atlantida(2) = "Esparta"
                atlantida(3) = "Jutiapa"
                atlantida(4) = "La Masica"
                atlantida(5) = "San Francisco"
                atlantida(6) = "Tela"
                atlantida(7) = "Arizna"
                cmbmunicipio.Items.Clear()
                For i = 0 To (atlantida.Length - 1) Step 1
                    cmbmunicipio.Items.Add(atlantida(i))
                Next
            Case 1
                Dim colon(9) As String
                colon(0) = "Trujillo"
                colon(1) = "Balfate"
                colon(2) = "Iriona"
                colon(3) = "Limón"
                colon(4) = "Sabá"
                colon(5) = "Santa Fe"
                colon(6) = "Santa Rosa de Aguán"
                colon(7) = "Sonaguera"
                colon(8) = "Tocoa"
                colon(9) = "Bonito Oriental"
                cmbmunicipio.Items.Clear()
                For i = 0 To (colon.Length - 1) Step 1
                    cmbmunicipio.Items.Add(colon(i))
                Next
            Case 2
                Dim comayagua(20) As String
                comayagua(0) = "Comayagua"
                comayagua(1) = "Ajuterique"
                comayagua(2) = "El Rosario"
                comayagua(3) = "Esquías"
                comayagua(4) = "Humuya"
                comayagua(5) = "La Libertad"
                comayagua(6) = "Lamaní"
                comayagua(7) = "La Trinidad"
                comayagua(8) = "Lejamaní"
                comayagua(9) = "Meámbar"
                comayagua(10) = "Minas de Oro"
                comayagua(11) = "Ojos de Agua"
                comayagua(12) = "San Jerónimo"
                comayagua(13) = "San José de Comayagua"
                comayagua(14) = "San José del Potrero"
                comayagua(15) = "San Luis"
                comayagua(16) = "San Sebastián"
                comayagua(17) = "Siguatepeque"
                comayagua(18) = "Villa de San Antonio "
                comayagua(19) = "Las Lajas"
                comayagua(20) = "Taulabé"
                cmbmunicipio.Items.Clear()
                For i = 0 To (comayagua.Length - 1) Step 1
                    cmbmunicipio.Items.Add(comayagua(i))
                Next
            Case 3
                Dim copan(22) As String
                copan(0) = "Santa Rosa de Copán"
                copan(1) = "Cabañas"
                copan(2) = "Concepción"
                copan(3) = "Copán Ruinas"
                copan(4) = "Corquín"
                copan(5) = "Cucuyagua"
                copan(6) = "Dolores"
                copan(7) = "Dulce Nombre"
                copan(8) = "El Paraíso"
                copan(9) = "Florida"
                copan(10) = "La Jigua"
                copan(11) = "La Unión"
                copan(12) = "Nueva Arcadia"
                copan(13) = "San Agustín"
                copan(14) = "San Antonio"
                copan(15) = "San Jerinimo"
                copan(16) = "San José"
                copan(17) = "San Juan de Opoa"
                copan(18) = "San Nicolás"
                copan(19) = "San Pedro"
                copan(20) = "Santa Rita "
                copan(21) = "Trinidad de Copán"
                copan(22) = "Veracruz"
                cmbmunicipio.Items.Clear()
                For i = 0 To (copan.Length - 1) Step 1
                    cmbmunicipio.Items.Add(copan(i))
                Next
            Case 4
                Dim cortes(11) As String
                cortes(0) = "San Pedro Sula"
                cortes(1) = "Choloma"
                cortes(2) = "Omoa"
                cortes(3) = "Pimienta"
                cortes(4) = "Potrerillos"
                cortes(5) = "Puerto Cortés"
                cortes(6) = "San Antonio de Cortés"
                cortes(7) = "San Francisco de Yojoa"
                cortes(8) = "San Manuel"
                cortes(9) = "Santa Cruz de Yojoa"
                cortes(10) = "villanueva"
                cortes(11) = "La Lima"
                cmbmunicipio.Items.Clear()
                For i = 0 To (cortes.Length - 1) Step 1
                    cmbmunicipio.Items.Add(cortes(i))
                Next

            Case 5
                Dim choluteca(15) As String
                choluteca(0) = "Choluteca"
                choluteca(1) = "Apacilagua"
                choluteca(2) = "Concepción de María"
                choluteca(3) = "Duyure"
                choluteca(4) = "El Corpus"
                choluteca(5) = "El Triunfo"
                choluteca(6) = "Marcovia"
                choluteca(7) = "Morolina"
                choluteca(8) = "Namasigüe"
                choluteca(9) = "Orocuina"
                choluteca(10) = "Pespire"
                choluteca(11) = "San Antonio de Flores"
                choluteca(12) = "San Isidro"
                choluteca(13) = "San José"
                choluteca(14) = "San Marcos de Colón"
                choluteca(15) = "Santa Ana de Yusguare"
                cmbmunicipio.Items.Clear()
                For i = 0 To (choluteca.Length - 1) Step 1
                    cmbmunicipio.Items.Add(choluteca(i))
                Next
            Case 6
                Dim paraiso(18) As String
                paraiso(0) = "Yuscarán"
                paraiso(1) = "Alauca"
                paraiso(2) = "Danlí"
                paraiso(3) = "El Paraiso"
                paraiso(4) = "Güinope"
                paraiso(5) = "Jacaleapa"
                paraiso(6) = "Liure"
                paraiso(7) = "Morocelí"
                paraiso(8) = "Oropolí"
                paraiso(9) = "Potrerillos"
                paraiso(10) = "San Antonio de Flors"
                paraiso(11) = "San Lucas"
                paraiso(12) = "San Matías"
                paraiso(13) = "Soledad"
                paraiso(14) = "Teupasenti"
                paraiso(15) = "Vado Ancho"
                paraiso(16) = "Yauyupe"
                paraiso(17) = "Trojes"
                paraiso(18) = "Texiguat"
                cmbmunicipio.Items.Clear()
                For i = 0 To (paraiso.Length - 1) Step 1
                    cmbmunicipio.Items.Add(paraiso(i))
                Next
            Case 7
                Dim francisco(27) As String
                francisco(0) = "Tegucigalpa"
                francisco(1) = "Alabarén"
                francisco(2) = "Cedros"
                francisco(3) = "Curarén"
                francisco(4) = "El Porvenir"
                francisco(5) = "Guaimaca"
                francisco(6) = "La Libertad"
                francisco(7) = "La Venta"
                francisco(8) = "Lepaterique"
                francisco(9) = "Maraita"
                francisco(10) = "marela"
                francisco(11) = "Nueva Armenia"
                francisco(12) = "Ojojona"
                francisco(13) = "Orica"
                francisco(14) = "Reitoca"
                francisco(15) = "Sabanagrande"
                francisco(16) = "San Antonio de Oriente"
                francisco(17) = "San Buenaventura"
                francisco(18) = "San Ignacio"
                francisco(19) = "San Juan de Flores(Cantarranas)"
                francisco(20) = "San Miguelito"
                francisco(21) = "Santa Ana"
                francisco(22) = "Santa Lucía"
                francisco(23) = "Talanga"
                francisco(24) = "Tatumbla"
                francisco(25) = "Valle de Ángeles"
                francisco(26) = "Villa de San Francisco"
                francisco(27) = "Vallecillo"
                cmbmunicipio.Items.Clear()
                For i = 0 To (francisco.Length - 1) Step 1
                    cmbmunicipio.Items.Add(francisco(i))
                Next

            Case 8
                Dim gracias(5) As String
                gracias(0) = "Puerto Lempira"
                gracias(1) = "Brus Laguna"
                gracias(2) = "Ahuas"
                gracias(3) = "Juan Francisco Bulnes"
                gracias(4) = "Ramón Villeda Morales"
                gracias(5) = "Wampusirpe"
                cmbmunicipio.Items.Clear()
                For i = 0 To (gracias.Length - 1) Step 1
                    cmbmunicipio.Items.Add(gracias(i))
                Next
            Case 9
                Dim intibuca(16) As String
                intibuca(0) = "La Esperanza"
                intibuca(1) = "Camasca"
                intibuca(2) = "Colomoncagua"
                intibuca(3) = "Concepción"
                intibuca(4) = "Dolores"
                intibuca(5) = "Intibucá"
                intibuca(6) = "Jesus de Otoro"
                intibuca(7) = "Magdalena"
                intibuca(8) = "Masaguara"
                intibuca(9) = "San Antonio"
                intibuca(10) = "San Isidro"
                intibuca(11) = "San Juan"
                intibuca(12) = "San Marcos de la Sierra"
                intibuca(13) = "San Miguel Guancapla"
                intibuca(14) = "Santa Lucía"
                intibuca(15) = "Yamaranguila"
                intibuca(16) = "San Francisco de Opalaca"
                cmbmunicipio.Items.Clear()
                For i = 0 To (intibuca.Length - 1) Step 1
                    cmbmunicipio.Items.Add(intibuca(i))
                Next
            Case 10
                Dim bahia(3) As String
                bahia(0) = "Roatán"
                bahia(1) = "Guanaja"
                bahia(2) = "José Santos Guardiola"
                bahia(3) = "Utila"
                cmbmunicipio.Items.Clear()
                For i = 0 To (bahia.Length - 1) Step 1
                    cmbmunicipio.Items.Add(bahia(i))
                Next
            Case 11
                Dim paz(18) As String
                paz(0) = "La Paz"
                paz(1) = "Aguanqueterique"
                paz(2) = "Cabañas"
                paz(3) = "Cane"
                paz(4) = "Chinacla"
                paz(5) = "Guajiquiro"
                paz(6) = "Lauterique"
                paz(7) = "Marcala"
                paz(8) = "Mercedes de Oriente"
                paz(9) = "Opatoro"
                paz(10) = "San Antonio del Norte"
                paz(11) = "San José"
                paz(12) = "San Juan"
                paz(13) = "San Pedro de Tutule"
                paz(14) = "Santa Ana"
                paz(15) = "Santa Elena"
                paz(16) = "Santa María"
                paz(17) = "Santiago de Puringa"
                paz(18) = "Yarula"
                cmbmunicipio.Items.Clear()
                For i = 0 To (paz.Length - 1) Step 1
                    cmbmunicipio.Items.Add(paz(i))
                Next
            Case 12
                Dim lempira(27) As String
                lempira(0) = "Gracias"
                lempira(1) = "Belén"
                lempira(2) = "Candelaria"
                lempira(3) = "Cololaca"
                lempira(4) = "Erandique"
                lempira(5) = "Gualcince"
                lempira(6) = "Guarita"
                lempira(7) = "La Campa"
                lempira(8) = "La Iguala"
                lempira(9) = "Las Flores"
                lempira(10) = "La Unión"
                lempira(11) = "La Virtud"
                lempira(12) = "Lepaera"
                lempira(13) = "Mapulaca"
                lempira(14) = "Piraera"
                lempira(15) = "San Andrés"
                lempira(16) = "San Francisco"
                lempira(17) = "San Juan Guarita"
                lempira(18) = "San Manuel Colohete"
                lempira(19) = "San Rafael"
                lempira(20) = "San Sebastián"
                lempira(21) = "Santa Cruz"
                lempira(22) = "Talgua"
                lempira(23) = "Tambla"
                lempira(24) = "Valladolid"
                lempira(25) = "Virginia"
                lempira(26) = "San Marcos de Caiquín"
                lempira(27) = "Tomalá"
                cmbmunicipio.Items.Clear()
                For i = 0 To (lempira.Length - 1) Step 1
                    cmbmunicipio.Items.Add(lempira(i))
                Next
            Case 13
                Dim ocotepeque(15) As String
                ocotepeque(0) = "Nueva Ocotepeque"
                ocotepeque(1) = "Belén Gualcho"
                ocotepeque(2) = "Concepción"
                ocotepeque(3) = "Doloren Merendón"
                ocotepeque(4) = "Fraternidad"
                ocotepeque(5) = "La Encarganición"
                ocotepeque(6) = "La labor"
                ocotepeque(7) = "Lucerna"
                ocotepeque(8) = "Mercedes"
                ocotepeque(9) = "San Fernando"
                ocotepeque(10) = "San Francisco del Valle"
                ocotepeque(11) = "San Jorge"
                ocotepeque(12) = "San Marcos"
                ocotepeque(13) = "Santa Fe"
                ocotepeque(14) = "Senseti"
                ocotepeque(15) = "Sinuapa"
                cmbmunicipio.Items.Clear()
                For i = 0 To (ocotepeque.Length - 1) Step 1
                    cmbmunicipio.Items.Add(ocotepeque(i))
                Next
            Case 14
                Dim olancho(22) As String
                olancho(0) = "Juticalpa"
                olancho(1) = "Campamento"
                olancho(2) = "Catacamas"
                olancho(3) = "Concordia"
                olancho(4) = "Dulce Nombre de Culmí"
                olancho(5) = "el Rosario"
                olancho(6) = "Esquipulas del Norte"
                olancho(7) = "Gualaco"
                olancho(8) = "Guarizoma"
                olancho(9) = "Guata"
                olancho(10) = "Guayape"
                olancho(11) = "Jano"
                olancho(12) = "La Unión"
                olancho(13) = "Mangulile"
                olancho(14) = "Manto"
                olancho(15) = "Salamá"
                olancho(16) = "San Esteban"
                olancho(17) = "San Francisco de Becerra"
                olancho(18) = "San Francisco de la Paz"
                olancho(19) = "Santa María del Real"
                olancho(20) = "Silca"
                olancho(21) = "Yocón"
                olancho(22) = "Patuca"
                cmbmunicipio.Items.Clear()
                For i = 0 To (olancho.Length - 1) Step 1
                    cmbmunicipio.Items.Add(olancho(i))
                Next
            Case 15
                Dim santa(27) As String
                santa(0) = "Santa Bárbara"
                santa(1) = "Arada"
                santa(2) = "Atima"
                santa(3) = "Azacualpa"
                santa(4) = "Ceguaca"
                santa(5) = "San José de las Colinas"
                santa(6) = "Concepción del Norte"
                santa(7) = "Concepción del Sur"
                santa(8) = "Chinda"
                santa(9) = "El Níspero"
                santa(10) = "Gualala"
                santa(11) = "Llama"
                santa(12) = "Macuelizo"
                santa(13) = "Naranjito"
                santa(14) = "Nuevo Celilac"
                santa(15) = "Petoa"
                santa(16) = "Protección"
                santa(17) = "Quimistán"
                santa(18) = "San Francisco de Ojuera"
                santa(19) = "San Luis"
                santa(20) = "San Marcos"
                santa(21) = "San Nicolás"
                santa(22) = "San Pedro Zacapa"
                santa(23) = "Santa Rita"
                santa(24) = "San Vicente Centenario"
                santa(25) = "Trinidad"
                santa(26) = "Las Vegas"
                santa(27) = "Nueva Frontera"
                cmbmunicipio.Items.Clear()
                For i = 0 To (santa.Length - 1) Step 1
                    cmbmunicipio.Items.Add(santa(i))
                Next
            Case 16
                Dim valle(8) As String
                valle(0) = "Alianza"
                valle(1) = "Amapala"
                valle(2) = "Aramecina"
                valle(3) = "Caridad"
                valle(4) = "Giascorán"
                valle(5) = "Langue"
                valle(6) = "Nacaome"
                valle(7) = "San Francisco de Coray"
                valle(8) = "san Lorenzo"
                cmbmunicipio.Items.Clear()
                For i = 0 To (valle.Length - 1) Step 1
                    cmbmunicipio.Items.Add(valle(i))
                Next
            Case 17
                Dim yoro(10) As String
                yoro(0) = "Yoro"
                yoro(1) = "Arenal"
                yoro(2) = "El Negrito"
                yoro(3) = "El Progreso"
                yoro(4) = "Jocón"
                yoro(5) = "Morazán"
                yoro(6) = "Olnachito"
                yoro(7) = "Santa Rita"
                yoro(8) = "Sulaco"
                yoro(9) = "Victoria"
                yoro(10) = "Yorito"
                cmbmunicipio.Items.Clear()
                For i = 0 To (yoro.Length - 1) Step 1
                    cmbmunicipio.Items.Add(yoro(i))
                Next
        End Select
    End Sub

    Private Sub chkF_CheckedChanged(sender As Object, e As EventArgs) Handles chkF.CheckedChanged
        If chkF.Checked = True Then
            chkM.Enabled = False
        Else
            chkM.Enabled = True
        End If
    End Sub

    Private Sub chkM_CheckedChanged(sender As Object, e As EventArgs) Handles chkM.CheckedChanged
        If chkM.Checked = True Then
            chkF.Enabled = False
        Else
            chkF.Enabled = True
        End If
    End Sub
End Class