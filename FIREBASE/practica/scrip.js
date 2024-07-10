// Import the functions you need from the SDKs you need
import { initializeApp } 
from "https://www.gstatic.com/firebasejs/9.6.10/firebase-app.js";
import { getAuth, GoogleAuthProvider, signInWithPopup } 
from "https://www.gstatic.com/firebasejs/9.6.10/firebase-auth.js";
import { getDatabase,ref, onValue, update, push, child}
from "https://www.gstatic.com/firebasejs/9.6.10/firebase-database.js"
import { getAuth, GoogleAuthProvider, signInWithPopup } 
from "https://www.gstatic.com/firebasejs/9.6.10/firebase-auth.js";
import { getDatabase,ref, onValue, update, push, child}
from "https://www.gstatic.com/firebasejs/9.6.10/firebase-database.js";

// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyBgxfEaV7fikWZe6qsrZgmmPk_-Z_12kC0",
  authDomain: "delmyfajardo2023.firebaseapp.com",
  projectId: "delmyfajardo2023",
  storageBucket: "delmyfajardo2023.appspot.com",
  messagingSenderId: "1083297921238",
  appId: "1:1083297921238:web:22ede3b220b2450fbdb177",
  measurementId: "G-SZKQTP53LT"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig)

//aca inicia mi programa 
var usuarioConectado = document.getElementById ('usuarioConectado');
var botonIniciar = document.getElementById('botonIniciar');
var botonCerrar = document.getElementById('botonCerrar');
var textomensaje = document.getElementById('textomensaje');
var mensajesChat = document.getElementById ('mensajeschat');
var nombreUsuarioConectado = ""
botonIniciar.onclick =  function (){}

document.getElementById('botonIniciar').onclick = async function ()
   {
    var auth = getAuth();
    var provider = new GoogleAuthProvider();
    auth.languaje ="es";
    var response = await signInWithPopup( auth , provider);
    alert (response.user.email);
   }