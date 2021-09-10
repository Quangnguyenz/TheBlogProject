index = 0;

function AddTag() {
    //Get a reference to the TagEntry input element 
    var tagEntry = document.getElementById("TagEntry");

    //Use the new search function to detect an error state
    let searchResult = search(tagEntry.value);
    if (searchResult != null) {
        //Trigger sweet alert for the empty string for the condition contained in the searchResult var
        Swal.fire({
            title: 'Error!',
            text: 'Do you want to continue',
            icon: 'error',
            confirmButtonText: 'Cool'
        })
    }
    else {

        //Create a new Select Option
        let newOption = new Option(tagEntry.value, tagEntry.value);
        document.getElementById("TagList").options[index++] = newOption;

    }

    //Clear out thr TagEntry control
    tagEntry.value = "";
    return true;
}

function DeleteTag() {
    let tagCount = 1
    while (tagCount > 0) {
        let tagList = document.getElementById("TagList");
        let selectedIndex = tagList.selectedIndex;
        if (selectedIndex >= 0) {
            tagList.options[selectedIndex] = null;
            --tagCount;
        }
        else {
            tagCount = 0;
        }
                   
        index--;
    }
}

$("form").on("submit", function () {
    $("#TagList option").prop("selected", "selected");
})

//Look for the tagValues variable to see if it has data

if (tagValues != '') {
    let tagArray = tagValues.split(",");
    for (let loop = 0; loop < tagArray.length; loop++) {
        //load up or replace the options we have
        ReplaceTag(tagArray[loop], loop)
        index++
    }
}

function ReplaceTag(tag, index) {
    let newOption = new Option(tag, tag);
    document.getElementById("TagList").options[index] = newOption;

}


//search function will detect either an empty or a duplicate tag
//and return an error string if an error is detected
function search(str) {
    if (str == "") {
        return 'Empty tags are not permitted'
    }

    var tagsEl = document.getElementById('TagList')
    if (tagsEl) {
        let options = tagsEl.Options;
        for (let index = 0; index < options.length; index++) {
            if (options[index].value == str)
                return `The Tag #${str} was detected as a duplicate and not permitted`            
        }
    }

}