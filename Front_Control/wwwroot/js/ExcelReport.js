﻿function fnExcelReport(id, name) {
    var tab_text = '<html xmlns: x="urn:schemas-microsoft-com:office:excel">';
    tab_text = tab_text + '<head><xml><x: ExcelWorkbook><x: ExcelWorksheets><x: ExcelWorksheet>';
    tab_text = tab_text + '<x: Name>Clientes</x: Name>';
    tab_text = tab_text + '<x: WorksheetOptions><x: Panes></x: Panes></x: WorksheetOptions ></x: ExcelWorksheet > ';
    tab_text = tab_text + '</x:ExcelWorksheets></x:ExcelWorkbook></xml></head><body>';
    tab_text = tab_text + "<table border='1px' style='color:black'>";


    var exportTable = $('#' + id).clone();
    exportTable.find('th').last().remove();
    exportTable.find('input').each(function (index, elem) { $(elem).remove(); });
    exportTable.find('a').each(function (index, elem) { $(elem).remove(); });

    tab_text = tab_text + exportTable.html();
    tab_text = tab_text + '</table></body></html>';
    var fileName = "ListaClientes" + '.xls';

    //Save the file
    var blob = new Blob([tab_text], { type: "application/vnd.ms-excel;charset=utf-8" })
    window.saveAs(blob, fileName);
}