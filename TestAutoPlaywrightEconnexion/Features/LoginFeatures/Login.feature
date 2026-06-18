Feature: Login

Scenario: Connexion valide
    Given je suis sur la page de login
    When je me connecte avec "hsw" et "@hsw"
    Then je vois la page d'accueil