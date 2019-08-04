import { AcmeUIPage } from './app.po';

describe('acme-ui App', function() {
  let page: AcmeUIPage;

  beforeEach(() => {
    page = new AcmeUIPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
