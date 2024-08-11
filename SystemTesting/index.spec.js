describe('Login Form', () => {
    it('should login successfully with correct credentials', () => {
      // Visit the login page
      cy.visit('path/to/your/login.html');
  
      // Enter valid credentials
      cy.get('input[name="username"]').type('user');
      cy.get('input[name="password"]').type('password');
  
      // Submit the form
      cy.get('button[type="submit"]').click();
  
      // Verify that the user is redirected to the dashboard
      cy.url().should('include', 'dashboard.html');
    });
  
    it('should show an alert with invalid credentials', () => {
      // Visit the login page
      cy.visit('path/to/your/login.html');
  
      // Enter invalid credentials
      cy.get('input[name="username"]').type('invalidUser');
      cy.get('input[name="password"]').type('wrongPassword');
  
      // Submit the form
      cy.get('button[type="submit"]').click();
  
      // Check for alert
      cy.on('window:alert', (str) => {
        expect(str).to.equal('Invalid credentials');
      });
    });
  });
  