const firstPasswordDefaultText = "Пароль может содержать буквы английского алфавита и цифры от 0 до 9. Минимальная длина пароля 8 символов, максимальная 16";
const firstPasswordIncorrectText = "Пароль не удовлетворяет условиям";
const firstPasswordCorrectText = "Пароль подходит"
const passwordMinLength = 8;
const passwordMaxLength = 16;

const secondPasswordDefaultText = "";
const secondPasswordIncorrectText = "Пароли не совпадают";
const secondPasswordCorrectText = "Пароли совпадают";

const loginDefaultText = "Логин может содержать буквы английского алфавита и цифры от 0 до 9, он не может быть длиннее 12 символов. Логин должен быть уникальным";
const loginCorrectText = "Логин свободен";
const loginIncorrectText = "Логин имеет неверный формат";
const loginNonUniqueText = "Такой логин занят";
const loginMinLength = 1;
const loginMaxLength = 12;

const emailDefaultText = "На этот адрес придёт письмо для подтверждения регистрации";
const emailCorrectText = "Подходящий почтовый адрес";
const emailIncorrectText = "Введённый почтовый адрес имеет неверный формат";

const phoneDefaultText = "";
const phoneCorrectText = "Подходящий номер телефона";
const phoneIncorrectText = "Введённый номер телефона имеет неверный формат";

const formIncorrectText = "Не все поля заполнены верно";

const defaultColor = "grey";
const incorrectColor = "red";
const correctColor = "green";

const arr_symbols = ['0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'];

function checkStringCorrectness(string,symbols,minLength,maxLength){
    if(string.length>=minLength && string.length<=maxLength){
        let flag = false;
        for(i=0;i<string.length;i++){
            for(j=0;j<symbols.length;j++){
                if(string[i]==symbols[j]){
                    flag = true;
                } 
            }
            if(flag == false){
                return false;
            }
            flag = false;
        }
        return true;
    }
    else {
        return false;
    }
}
function checkPassword1(){
    let password = $('#passwordInput1').val();
    if(password.length>0){
        let flag = checkStringCorrectness(password,arr_symbols,passwordMinLength,passwordMaxLength);
        if(flag == false){
            addColorizedTextToElementById(incorrectColor,firstPasswordIncorrectText,"passwordHelp1");
            return false;
        }
        else {
            addColorizedTextToElementById(correctColor,firstPasswordCorrectText,"passwordHelp1");
            return true;
        }
    }
    else{
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
//Нужно реализовать функцию позже
function checkLoginUnique(){
    return true;
}

function checkLogin(){
    let login = $("#loginInput").val();
    if(login.length>0){
        let flag = checkStringCorrectness(login,arr_symbols,loginMinLength,loginMaxLength);
        console.log(flag);
        if(flag == true){
            if(checkLoginUnique() == true){
                addColorizedTextToElementById(correctColor,loginCorrectText,"loginHelp");
                return true;
            }
            else {
                addColorizedTextToElementById(incorrectColor,loginNonUniqueText,"loginHelp");
                return false;
            }
        }
        else {
            addColorizedTextToElementById(incorrectColor,loginIncorrectText,"loginHelp");
            return false;
        }
    }
    else{
        addColorizedTextToElementById(defaultColor,loginDefaultText,"loginHelp");
        return false;
    }

}
//Доделать позже
function isEmailStringCorrect(string){
    return true;
}
function checkEmail(){
    let email = $("#emailInput").val();
    if(email.length>0){
        if(isEmailStringCorrect(email)){
            addColorizedTextToElementById(correctColor,emailCorrectText,"emailHelp");
            return true;
        }
        else {
            addColorizedTextToElementById(incorrectColor,emailIncorrectText,"emailHelp");
            return false;
        }
    }
    else{
        addColorizedTextToElementById(defaultColor,emailDefaultText,"emailHelp");
        return false;
    }

}

//Доделать
function isPhoneStringCorrect(string){
    return true;
}

function checkPhone(){
    let phone = $("#phoneInput").val();
    if(phone.length>0){
        if(isPhoneStringCorrect(phone)) {
            addColorizedTextToElementById(correctColor,phoneCorrectText,'phoneHelp');
            return true;
        }
        else{
            addColorizedTextToElementById(incorrectColor,phoneIncorrectText,'phoneHelp');
            return true;
        }
    }
    else{
        addColorizedTextToElementById(defaultColor,phoneDefaultText,'phoneHelp');
        return true;
    }
}

function sendForm(){
    if(checkLogin() && checkPassword1() && checkSecondPasswordIsSimilarToFirst() && checkEmail() && checkPhone()){
        let form = document.getElementById("regForm");
        form.action = "url";
        form.method = "POST";
        form.submit()
        return true;
    }
    else {
        addColorizedTextToElementById(incorrectColor,formIncorrectText,"sendBtnHelp");
        return false;
    }
}
        