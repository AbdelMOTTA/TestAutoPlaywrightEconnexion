Feature: Login

Scenario: Connexion valide
    Given je suis sur la page de login
    When je me connecte avec "admin" et "admin"
    Then je vois la page d'accueil
