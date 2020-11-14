const firstPasswordDefaultText = "Пароль может содержать буквы английского алфавита и цифры от 0 до 9. Минимальная длина пароля 8 символов, максимальная 16";
const firstPasswordIncorrectText = "Пароль не удовлетворяет условиям";
const firstPasswordCorrectText = "Пароль подходит"

const secondPasswordDefaultText = "";
const secondPasswordIncorrectText = "Пароли не совпадают";
const secondPasswordCorrectText = "Пароли совпадают";

const defaultColor = "grey";
const incorrectColor = "red";
const correctColor = "green";
function checkPassword1(){
    const arr_symbols = ['0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'];
    let password = $('#passwordInput1').val();
    if(password.length>0){
        if(password.length>=8 && password.length<=16){
            let flag = false;
            for(i=0;i<password.length;i++){
                for(j=0;j<arr_symbols.length;j++){
                    if(password[i]==arr_symbols[j]){
                        flag = true;
                    } 
                }
                if(flag == false){
                    addColorizedTextToElementById(incorrectColor,firstPasswordIncorrectText,"passwordHelp1");
                    return false;
                }
                flag = false;
            }
            addColorizedTextToElementById(correctColor,firstPasswordCorrectText,"passwordHelp1");
            return true;
        }
        else {
            addColorizedTextToElementById(incorrectColor,firstPasswordIncorrectText,"passwordHelp1");
            return false;
        }
    }
    else {
        addColorizedTextToElementById(defaultColor,firstPasswordDefaultText,"passwordHelp1");
        return false;
    }
  
};
function addColorizedTextToElementById(color,text,elementId){
    $('#'+elementId).empty().append(text);
    document.getElementById(elementId).style.setProperty('color',color,'important');
}

function checkSecondPasswordIsSimilarToFirst(){
        if(checkPassword1()==true){
        let firstPassword = $("#passwordInput1").val();
        let secondPassword = $("#passwordInput2").val();
        if(secondPassword.length==0){
            addColorizedTextToElementById(defaultColor,secondPasswordDefaultText,"passwordHelp2");
            return false;
        }
        else if(secondPassword==firstPassword){
            addColorizedTextToElementById(correctColor,secondPasswordCorrectText,"passwordHelp2");
            return true;
        }
        else {
            addColorizedTextToElementById(incorrectColor,secondPasswordIncorrectText,"passwordHelp2");
            return false;
        }
    }
    else {
        addColorizedTextToElementById(defaultColor,secondPasswordDefaultText,"passwordHelp2");
        return false;
    }
}
        