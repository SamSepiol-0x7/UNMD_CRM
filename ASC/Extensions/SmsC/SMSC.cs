using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ASC.Extensions.SmsC
{
	// Token: 0x02000BB1 RID: 2993
	public class SMSC : ISMSC
	{
		// Token: 0x06005401 RID: 21505 RVA: 0x00167BA8 File Offset: 0x00165DA8
		public void SetLogin(string login)
		{
			this.SMSC_LOGIN = login;
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x00167BBC File Offset: 0x00165DBC
		public void SetPassword(string password)
		{
			this.SMSC_PASSWORD = password;
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x00167BD0 File Offset: 0x00165DD0
		public string[] send_sms(string phones, string message, int translit = 0, string time = "", int id = 0, int format = 0, string sender = "", string query = "", string[] files = null)
		{
			if (files != null)
			{
				this.SMSC_POST = true;
			}
			string[] array = new string[]
			{
				"flash=1",
				"push=1",
				"hlr=1",
				"bin=1",
				"bin=2",
				"ping=1",
				"mms=1",
				"mail=1",
				"call=1",
				"viber=1",
				"soc=1"
			};
			return this._smsc_send_cmd("send", string.Concat(new string[]
			{
				"cost=3&phones=",
				this._urlencode(phones),
				"&mes=",
				this._urlencode(message),
				"&id=",
				id.ToString(),
				"&translit=",
				translit.ToString(),
				(format > 0) ? ("&" + array[format - 1]) : "",
				(sender != "") ? ("&sender=" + this._urlencode(sender)) : "",
				(time != "") ? ("&time=" + this._urlencode(time)) : "",
				(query != "") ? ("&" + query) : ""
			}), files);
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x00167D48 File Offset: 0x00165F48
		public void send_sms_mail(string phones, string message, int translit = 0, string time = "", int id = 0, int format = 0, string sender = "")
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.To.Add("send@send.smsc.ru");
			mailMessage.From = new MailAddress("api@smsc.ru", "");
			mailMessage.Body = string.Concat(new string[]
			{
				this.SMSC_LOGIN,
				":",
				this.SMSC_PASSWORD,
				":",
				id.ToString(),
				":",
				time,
				":",
				translit.ToString(),
				",",
				format.ToString(),
				",",
				sender,
				":",
				phones,
				":",
				message
			});
			mailMessage.BodyEncoding = Encoding.GetEncoding("utf-8");
			mailMessage.IsBodyHtml = false;
			new SmtpClient("send.smsc.ru", 25)
			{
				DeliveryMethod = SmtpDeliveryMethod.Network,
				EnableSsl = false,
				UseDefaultCredentials = false
			}.Send(mailMessage);
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06005405 RID: 21509 RVA: 0x00167E5C File Offset: 0x0016605C
		public string[] sms_cost
		{
			get
			{
				string[] array = new string[]
				{
					"flash=1",
					"push=1",
					"hlr=1",
					"bin=1",
					"bin=2",
					"ping=1",
					"mms=1",
					"mail=1",
					"call=1",
					"viber=1",
					"soc=1"
				};
				return this._smsc_send_cmd("send", string.Concat(new string[]
				{
					"cost=1&phones=",
					this._urlencode(phones),
					"&mes=",
					this._urlencode(message),
					translit.ToString(),
					(format > 0) ? ("&" + array[format - 1]) : "",
					(sender != "") ? ("&sender=" + this._urlencode(sender)) : "",
					(query != "") ? "&query" : ""
				}), null);
			}
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06005406 RID: 21510 RVA: 0x00167F78 File Offset: 0x00166178
		public string[] status
		{
			get
			{
				string[] array = this._smsc_send_cmd("status", string.Concat(new string[]
				{
					"phone=",
					this._urlencode(phone),
					"&id=",
					this._urlencode(id),
					"&all=",
					all.ToString()
				}), null);
				if (id.IndexOf(',') != -1)
				{
					if (array.Length == 1)
					{
						if (array[0].IndexOf('-') == 2)
						{
							return array[0].Split(new char[]
							{
								','
							});
						}
					}
					Array.Resize<string[]>(ref this.D2Res, 0);
					Array.Resize<string[]>(ref this.D2Res, array.Length);
					for (int i = 0; i < this.D2Res.Length; i++)
					{
						this.D2Res[i] = array[i].Split(new char[]
						{
							','
						});
					}
					Array.Resize<string>(ref array, 1);
					array[0] = "1";
				}
				else
				{
					int num = (all == 1) ? 9 : 12;
					if (all > 0 && array.Length > num && (array.Length < num + 5 || array[num + 5] != "HLR"))
					{
						array = string.Join(",", array).Split(",".ToCharArray(), num);
					}
				}
				return array;
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06005407 RID: 21511 RVA: 0x001680B8 File Offset: 0x001662B8
		public string balance
		{
			get
			{
				string[] array = this._smsc_send_cmd("balance", "", null);
				if (array.Length != 1)
				{
					return "";
				}
				return array[0];
			}
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x001680E8 File Offset: 0x001662E8
		private string[] _smsc_send_cmd(string cmd, string arg, string[] files = null)
		{
			arg = string.Concat(new string[]
			{
				"login=",
				this._urlencode(this.SMSC_LOGIN),
				"&psw=",
				this._urlencode(this.SMSC_PASSWORD),
				"&fmt=1&charset=utf-8&",
				arg
			});
			string requestUriString;
			string text = requestUriString = "http://smsc.ru/sys/" + cmd + ".php" + (this.SMSC_POST ? "" : ("?" + arg));
			int i = 0;
			string text3;
			for (;;)
			{
				if (i++ > 0)
				{
					requestUriString = text.Replace("smsc.ru/", "www" + i.ToString() + ".smsc.ru/");
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				if (this.SMSC_POST)
				{
					httpWebRequest.Method = "POST";
					string text2 = "----------" + DateTime.Now.Ticks.ToString("x");
					byte[] bytes = Encoding.ASCII.GetBytes("--" + text2 + "--\r\n");
					StringBuilder stringBuilder = new StringBuilder();
					byte[] array = new byte[0];
					if (files == null)
					{
						httpWebRequest.ContentType = "application/x-www-form-urlencoded";
						array = Encoding.UTF8.GetBytes(arg);
						httpWebRequest.ContentLength = (long)array.Length;
					}
					else
					{
						httpWebRequest.ContentType = "multipart/form-data; boundary=" + text2;
						string[] array2 = arg.Split(new char[]
						{
							'&'
						});
						int num = files.Length;
						for (int j = 0; j < array2.Length + num; j++)
						{
							stringBuilder.Clear();
							stringBuilder.Append("--");
							stringBuilder.Append(text2);
							stringBuilder.Append("\r\n");
							stringBuilder.Append("Content-Disposition: form-data; name=\"");
							bool flag = j < num;
							string[] array3 = new string[0];
							if (!flag)
							{
								array3 = array2[j - num].Split(new char[]
								{
									'='
								});
								stringBuilder.Append(array3[0]);
							}
							else
							{
								stringBuilder.Append("File" + (j + 1).ToString());
								stringBuilder.Append("\"; filename=\"");
								stringBuilder.Append(Path.GetFileName(files[j]));
							}
							stringBuilder.Append("\"");
							stringBuilder.Append("\r\n");
							stringBuilder.Append("Content-Type: ");
							stringBuilder.Append(flag ? "application/octet-stream" : "text/plain; charset=\"utf-8\"");
							stringBuilder.Append("\r\n");
							stringBuilder.Append("Content-Transfer-Encoding: binary");
							stringBuilder.Append("\r\n");
							stringBuilder.Append("\r\n");
							string s = stringBuilder.ToString();
							byte[] bytes2 = Encoding.UTF8.GetBytes(s);
							array = this._concatb(array, bytes2);
							if (flag)
							{
								FileStream fileStream = new FileStream(files[j], FileMode.Open, FileAccess.Read);
								byte[] array4 = new byte[checked((uint)Math.Min(4096, (int)fileStream.Length))];
								int newSize;
								while ((newSize = fileStream.Read(array4, 0, array4.Length)) != 0)
								{
									byte[] sarr = array4;
									Array.Resize<byte>(ref sarr, newSize);
									array = this._concatb(array, sarr);
								}
							}
							else
							{
								byte[] bytes3 = Encoding.UTF8.GetBytes(array3[1]);
								array = this._concatb(array, bytes3);
							}
							array = this._concatb(array, Encoding.UTF8.GetBytes("\r\n"));
						}
						array = this._concatb(array, bytes);
						httpWebRequest.ContentLength = (long)array.Length;
					}
					httpWebRequest.GetRequestStream().Write(array, 0, array.Length);
				}
				try
				{
					text3 = new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream()).ReadToEnd();
					goto IL_3C3;
				}
				catch (WebException)
				{
					text3 = "";
					goto IL_3C3;
				}
				IL_3BA:
				if (i >= 5)
				{
					break;
				}
				continue;
				IL_3C3:
				if (!(text3 == ""))
				{
					break;
				}
				goto IL_3BA;
			}
			if (text3 == "")
			{
				text3 = ",";
			}
			char c = ',';
			if (cmd == "status")
			{
				string[] array5 = arg.Split(new char[]
				{
					'&'
				});
				for (i = 0; i < array5.Length; i++)
				{
					string[] array6 = array5[i].Split("=".ToCharArray(), 2);
					if (array6[0] == "id" && array6[1].IndexOf("%2c") > 0)
					{
						c = '\n';
					}
				}
			}
			return text3.Split(new char[]
			{
				c
			});
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x00168568 File Offset: 0x00166768
		private string _urlencode(string str)
		{
			if (this.SMSC_POST)
			{
				return str;
			}
			return Uri.EscapeDataString(str);
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x00168588 File Offset: 0x00166788
		private byte[] _concatb(byte[] farr, byte[] sarr)
		{
			int destinationIndex = farr.Length;
			Array.Resize<byte>(ref farr, farr.Length + sarr.Length);
			Array.Copy(sarr, 0, farr, destinationIndex, sarr.Length);
			return farr;
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x001685B4 File Offset: 0x001667B4
		private void _print_debug(string str)
		{
			MessageBox.Show(str);
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x001685C8 File Offset: 0x001667C8
		public SMSC()
		{
		}

		// Token: 0x0400374B RID: 14155
		private string SMSC_LOGIN = "login";

		// Token: 0x0400374C RID: 14156
		private string SMSC_PASSWORD = "password";

		// Token: 0x0400374D RID: 14157
		private bool SMSC_POST;

		// Token: 0x0400374E RID: 14158
		private const bool SMSC_HTTPS = false;

		// Token: 0x0400374F RID: 14159
		private const string SMSC_CHARSET = "utf-8";

		// Token: 0x04003750 RID: 14160
		private const bool SMSC_DEBUG = false;

		// Token: 0x04003751 RID: 14161
		private const string SMTP_FROM = "api@smsc.ru";

		// Token: 0x04003752 RID: 14162
		private const string SMTP_SERVER = "send.smsc.ru";

		// Token: 0x04003753 RID: 14163
		private const string SMTP_LOGIN = "";

		// Token: 0x04003754 RID: 14164
		private const string SMTP_PASSWORD = "";

		// Token: 0x04003755 RID: 14165
		public string[][] D2Res;
	}
}
