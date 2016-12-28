$.validator.addMethod('rule',
    function (value, element, parameters) {
        var ruleFunc = window[parameters['name']];
        return ruleFunc(value, element);
    }
);

$.validator.unobtrusive.adapters.add(
    'rule',
    ['name'],
    function (options) {
        options.rules['rule'] = {
            name: options.params['name']
        };
        options.messages['rule'] = options.message;
    });

$.validator.addMethod("isdateafter", function (value, element, params) {
    var parts = element.name.split(".");
    var prefix = "";
    if (parts.length > 1)
        prefix = parts[0] + ".";
    var startdatevalue = $('input[name="' + prefix + params.propertytested + '"]').val();
    if (!value || !startdatevalue)
        return true;

    var startdate = moment(startdatevalue, "DD-MMM-YYYY");
    var enddate = moment(value, "DD-MMM-YYYY");

    return (params.allowequaldates) ? startdate <= enddate : startdate < enddate;
});

$.validator.unobtrusive.adapters.add(
    'isdateafter', ['propertytested', 'allowequaldates'], function (options) {
        options.rules['isdateafter'] = options.params;
        options.messages['isdateafter'] = options.message;
    });

$.validator.addMethod("isfuturedate", function (value, element, params) {
    if (!value)
        return true;

    var thedate = moment(value, "DD-MMM-YYYY");

    return thedate > new Date();
});

$.validator.unobtrusive.adapters.add(
    'isfuturedate', [], function (options) {
        options.rules['isfuturedate'] = options.params;
        options.messages['isfuturedate'] = options.message;
    });

$.validator.addMethod("ispastdate", function (value, element, params) {
    if (!value)
        return true;

    var thedate = moment(value, "DD-MMM-YYYY");

    return (params.includetoday) ? thedate <= new Date() : thedate < new Date();
});

$.validator.unobtrusive.adapters.add(
    'ispastdate', ['includetoday'], function (options) {
        options.rules['ispastdate'] = options.params;
        options.messages['ispastdate'] = options.message;
    });

$.validator.addMethod("issmallerthanmtoquantity", function (value, element, params) {
    var parts = element.name.split(".");
    var prefix = "";
    if (parts.length > 1)
        prefix = parts[0] + ".";

    var mtoquantityvalue = $('input[name="' + prefix + params.mtoquantityproperty + '"]').val();
    var previousquantityvalue = $('input[name="' + prefix + params.previousquantityproperty + '"]').val();

    //    alert(params.previousquantityproperty);
    //    alert(value + " " + mtoquantityvalue + " " + previousquantityvalue);

    if (!value || !mtoquantityvalue || !previousquantityvalue)
        return true;

    return parseFloat(mtoquantityvalue) >= parseFloat(previousquantityvalue) + parseFloat(value);
});

$.validator.unobtrusive.adapters.add(
    'issmallerthanmtoquantity', ['mtoquantityproperty', 'previousquantityproperty'], function (options) {
        options.rules['issmallerthanmtoquantity'] = options.params;
        options.messages['issmallerthanmtoquantity'] = options.message;
    });

$.validator.addMethod("isdatebetween", function (value, element, params) {
    if (!value || value.toString().trim() === '') {
        return true;
    }

    var fromdate = moment(params.fromdate, "DD-MMM-YYYY");
    var todate = moment(params.todate, "DD-MMM-YYYY");
    var date = moment(value, "DD-MMM-YYYY");

    return (params.allowequal) ? (date >= fromdate && date <= todate) : (date > fromdate && date < todate);
});

$.validator.unobtrusive.adapters.add(
    'isdatebetween', ['fromdate', 'todate', 'allowequal'], function (options) {
        options.rules['isdatebetween'] = options.params;
        options.messages['isdatebetween'] = options.message;
    });

$.validator.addMethod("isnumber", function (value, element, params) {
    if (!value || value.toString().trim() === '') {
        return true;
    }

    var regex = /^\d+$/;
    return regex.test(value);
});

$.validator.unobtrusive.adapters.add(
    'isnumber', [], function (options) {
        options.rules['isnumber'] = options.params;
        options.messages['isnumber'] = options.message;
    });

$.validator.addMethod("isnotexceeded", function (value, element, params) {
    var parts = element.name.split(".");
    var prefix = "";
    if (parts.length > 1)
        prefix = parts[0] + ".";

    var returnqtypropertyname = $('input[name="' + prefix + params.returnqtypropertyname + '"]').val();
    var qtyonsitepropertyname = $('input[name="' + prefix + params.qtyonsitepropertyname + '"]').val();

    if (!value || !returnqtypropertyname || !qtyonsitepropertyname)
        return true;

    return parseInt(returnqtypropertyname) <= parseInt(qtyonsitepropertyname);
});

$.validator.unobtrusive.adapters.add(
     'isnotexceeded', ['returnqtypropertyname', 'qtyonsitepropertyname'], function (options) {
         options.rules['isnotexceeded'] = options.params;
         options.messages['isnotexceeded'] = options.message;
     });

$.validator.addMethod("isrequireddateafter", function (value, element, params) {
    var parts = element.name.split(".");
    var prefix = "";
    if (parts.length > 1)
        prefix = parts[0] + ".";
    var startdatevalue = $('input[name="' + prefix + params.propertytested + '"]').val();
    //if (!value || !startdatevalue)
    //    return true;

    return (value !== "" && startdatevalue !== "") || (value === "" && startdatevalue === "");
});

$.validator.unobtrusive.adapters.add(
    'isrequireddateafter', ['propertytested'], function (options) {
        options.rules['isrequireddateafter'] = options.params;
        options.messages['isrequireddateafter'] = options.message;
    });