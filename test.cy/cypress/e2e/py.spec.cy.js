describe('template spec', () => {
  it('passes', () => {
    cy.visit('http://localhost:8000/')

    cy.get('[data-testid="about_nav"]')
      .click();
  })
})