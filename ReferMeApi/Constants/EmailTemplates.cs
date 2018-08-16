using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Constants
{
    public static class EmailTemplates
    {
        public const string ACCOUNT_VERFICATION_EMAIL = @"<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>
                                                            <html>
                                                            <head>
                                                              <meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>
                                                              <title>Referrify</title>
                                                            </head>


                                                            <body leftmargin='0' marginwidth='0' topmargin='0' marginheight='0' offset='0' style='margin: 0pt auto; padding: 0px; background:#FFFFFF;'>
                                                              <table id='main' width='100%' height='100%' cellpadding='0' cellspacing='0' border='0' bgcolor='#FFFFFF'>
                                                                <tbody>
                                                                  <tr>
                                                                    <td valign='top'>
                                                                      <table class='innermain' cellpadding='0' width='580' cellspacing='0' border='0' bgcolor='#FFFFFF' align='center' style='margin:0 auto; table-layout: fixed;'>
                                                                        <tbody>

                                                                          <tr>
                                                                            <td colspan='4'>


                                                                              <table class='logo' width='100%' cellpadding='0' cellspacing='0' border='0'>
                                                                                <tbody>
                                                                                  <tr>
                                                                                    <td colspan='2' height='30'></td>
                                                                                  </tr>
                                                                                  <tr>
                                                                                    <td bgcolor='#343a40' valign='top' align='center'>
                                                                                      <span style='font-family: sans-serif; color: #ffc107;'><h1>Referrify</h1></span>
                                                                                    </td>
                                                                                  </tr>
                                                                                  <tr>
                                                                                    <td bgcolor='#ffc107' colspan='2' height='3'></td>
                                                                                  </tr>
                                                                                </tbody>
                                                                              </table>

                                                                              <table width='100%' cellpadding='0' cellspacing='0' border='0' bgcolor='#ffffff' style='border-radius: 4px; box-shadow: 0 2px 8px rgba(0,0,0,0.05);'>
                                                                                <tbody>
                      
                                                                                  <tr>
                                                                                    <td height='40'></td>
                                                                                  </tr>
                                                                                  <tr style='font-family: sans-serif; color:#343a40; font-size:14px; line-height:20px; margin-top:20px;'>
                                                                                    <td class='content' colspan='2' valign='top' align='center' style='padding-left:90px; padding-right:90px;'>

                                                                                      <table width='100%' cellpadding='0' cellspacing='0' border='0' bgcolor='#fff0c4' style='border: 1px solid #343a40; border-radius: 7px; padding: 15px;'>
                                                              <tbody>
                                                                <tr>
                                                              <td align='center' valign='bottom' colspan='2' cellpadding='3'>
                                                               <img alt='Referrify' width='80' src='https://cdn.iconscout.com/public/images/icon/premium/png-512/mail-read-email-envelope-chat-communication-3921334d5e28bb4e-512x512.png' />
                                                              </td>
                                                            </tr>

                                                            <tr><td height='20'></td></tr>


                                                                <tr>
                                                                  <td align='center'>
                                                                    <span style='font-size: 22px;line-height: 24px;'>
                                                                      Verify your email address
                                                                    </span>
                                                                  </td>
                                                                </tr>

                                                                <tr><td height='24'></td></tr>
                                                            <tr>
                                                              <td><hr /></td>
                                                            </tr>

                                                            <tr><td height='24' &nbsp;=''></td></tr>


                                                                <tr>
                                                                  <td align='center'>
                                                                    <span style='color:#343a40;font-size:16px;line-height:26px;'>
                                                                      In order to start using your Referrify account, you need to confirm your email address. Please click the button below to do the same.
                                                                    </span>
                                                                  </td>
                                                                </tr>
                                                                <tr><td height='20'></td></tr>
                                                                <tr>
                                                                  <td valign='top' width='48%' align='center'>
                                                                    <span>
                                                                      <a href='{{VERIFICATION_LINK}}' style='display:block; padding:3px 25px; background-color:#343a40; color:#ffc107; border: 2px solid #ffc107; border-radius:10px; text-decoration:none;'><h2>Verify Email Address</h2></a>
                                                                    </span>
                                                                  </td>
                                                                </tr>

                                                                <tr><td height='40'></td></tr>




                                                              </tbody>
                                                            </table>

                                                                                    </td>
                                                                                  </tr>
                                                                <tr><td height='40'></td></tr>
                                                                                </tbody>
                                                                              </table>

                                                                            </td>
                                                                          </tr>
                                                                        </tbody>
                                                                      </table>
                                                                    </td>
                                                                  </tr>
                                                                </tbody>
                                                              </table>
                                                            </body>
                                                            </html>";
    }
}
