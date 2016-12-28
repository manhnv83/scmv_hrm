var EmployeeScript = (function (window, undefined) {
    var doDeleteEmployeeConfirm = function (deleteEmployeeUrl, confirmMessage, deleteSuccessMessage, deleteFailMessage) {
        $('.delete-item').confirmModal({
            confirmTitle: 'Warning!',
            confirmMessage: confirmMessage,
            confirmOk: 'Yes',
            confirmCancel: 'No',
            confirmDirection: 'rtl',
            confirmStyle: 'primary',
            confirmCallback: function (confirmLink) {
                var id = $(confirmLink).attr('itemid');
                $.ajax({
                    async: true,
                    url: deleteEmployeeUrl,
                    type: "POST",
                    dataType: "json",
                    data: { payrollNumber: id }
                }).done(function (data) {
                    //debugger;
                    if (data.status === "Success") {
                        //debugger;
                        // 1: Delete success
                        var urlSearch = '';

                        var urlSearchPaged = deleteEmployeeUrl.replace("DeleteEmployee", "SearchEmployee");

                        try {
                            urlSearch = $('#employee-results th[class*="sorting_"] > a').attr("href");
                        } catch (e) {
                            urlSearch = urlSearchPaged;
                        }

                        var pageid = +$('#pager li[class="active"] > a').text();

                        var trCount = $('#employee-results tbody tr').size();

                        if (trCount === 1) {
                            //debugger;
                            pageid = pageid - 1; // Only one item in a page, after delete this item, the system will go to the previous page
                        }

                        if (pageid <= 0) {
                            //debugger;
                            pageid = 1; // Default page ~ pageid = 1
                        }

                        var subStr1 = urlSearch.match("(.*)page=");

                        var subStr2 = urlSearch.match("&sortOrder=(.*)");

                        var url = subStr1[1] + 'page=' + pageid + '&sortOrder=' + subStr2[1];

                        //debugger;

                        if (pageid === 1) {
                            $.ajax({
                                url: urlSearchPaged,
                                type: "POST",
                                data: $('#searchEmployeeForm').serialize(),
                                success: function (result) {
                                    //debugger;
                                    $('#btnSearchEmployee').prop("disabled", false);
                                    $("#divProcessing").hide();
                                    $('#employee-result-message').show();
                                    $('#employee-result-message').html(deleteSuccessMessage);
                                    //debugger;
                                    if (result.Success == null) {
                                        //debugger;
                                        $('#employee-result-message').hide();
                                        $('#EmployeeResultTable').html(result); // assuming response is HTML
                                    } else {
                                        //debugger;
                                        if (!result.Success) {
                                            //debugger;
                                            $('#employee-result-message').show();
                                            $('#employee-result-message').html(result.Message);
                                        }
                                    }
                                },
                                error: function (xhr, status, error) {
                                    //debugger;
                                    $('#btnSearchEmployee').prop("disabled", false);
                                    $("#divProcessing").hide();
                                    $('#employee-result-message').show();
                                    $('#employee-result-message').html("error");
                                }
                            });
                        } else {
                            //debugger;
                            $.ajax({
                                url: url,
                                type: "GET",
                                success: function (result) {
                                    //debugger;
                                    $('#btnSearchEmployee').prop("disabled", false);
                                    $("#divProcessing").hide();
                                    $('#employee-result-message').show();
                                    $('#employee-result-message').html(deleteSuccessMessage);
                                    if (result.Success == null) {
                                        //debugger;
                                        $('#employee-result-message').hide();
                                        $('#EmployeeResultTable').html(result); // assuming response is HTML
                                    } else {
                                        //debugger;
                                        if (!result.Success) {
                                            //debugger;
                                            $('#employee-result-message').show();
                                            $('#employee-result-message').html(result.Message);
                                        }
                                    }
                                },
                                error: function (xhr, status, error) {
                                    $('#btnSearchEmployee').prop("disabled", false);
                                    $("#divProcessing").hide();
                                    $('#employee-result-message').show();
                                    $('#employee-result-message').html("error");
                                }
                            });
                        }
                    } else {
                        // 2: Delete fail
                        $('#employee-result-message').show();
                        $('#employee-result-message').html(deleteFailMessage);
                    }
                });
            }
        });
    };

    return {
        doDeleteEmployeeConfirm: doDeleteEmployeeConfirm
    };
})(window);