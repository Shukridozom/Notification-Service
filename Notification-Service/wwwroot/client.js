// Script to initialize firebase and receive messages.
// In a real application this would be in a separate JavaScript file.

let fcmToken;

// Initialize Firebase
let config = {
    apiKey: "AIzaSyCaw1g4DmWfzh8lL73qX6nd82ANnunZO-w",
    authDomain: "demoproject-c60fa.firebaseapp.com",
    projectId: "demoproject-c60fa",
    storageBucket: "demoproject-c60fa.appspot.com",
    messagingSenderId: "776867528857",
    appId: "1:776867528857:web:e03626edad6bdc6e6a7808",
    measurementId: "G-03LS8P5HWL"
};

firebase.initializeApp(config);

const messaging = firebase.messaging();

navigator.serviceWorker.register("service-worker.js")
    .then(registration => {
        messaging.useServiceWorker(registration);
        return messaging.requestPermission();
    })
    .then(() => {
        return messaging.getToken();
    })
    .then(currentToken => {
        // console.log("Here is the token: " + currentToken);
        fcmToken = currentToken;
        $("#fcmToken").text(fcmToken);

    })
    .catch((err) => {
        console.log(err.stack);
    });

