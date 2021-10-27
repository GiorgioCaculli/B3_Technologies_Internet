describe('My first test', () => {
  it('Data is loaded', () => {
    cy.visit("http://localhost:4200");
    cy.get("input[type=text]").type("J'aime les smourbifs");
    cy.get("input[type=submit]").click();
    cy.contains("J'aime les smourbifs");
  })
});
