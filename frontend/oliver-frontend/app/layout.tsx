import { GeistSans } from 'geist/font'
import './globals.css'
import Header from '@/components/Header'
import { cookies } from 'next/headers'
import { createClient } from '@/utils/supabase/server'
import Signin from '@/components/SignIn'

const defaultUrl = process.env.VERCEL_URL
  ? `https://${process.env.VERCEL_URL}`
  : 'http://localhost:3000'

export const metadata = {
  metadataBase: new URL(defaultUrl),
  title: 'Next.js and Supabase Starter Kit',
  description: 'The fastest way to build apps with Next.js and Supabase',
}



export default async function RootLayout({
  children,
}: {
  children: React.ReactNode
}) {
  const cookieStore = cookies()
const supabase = createClient(cookieStore)

//  //this gets the user from authentication
//  const {
//   data: { user },
// } = await supabase.auth.getUser();
  return (
    <html lang="en" className={GeistSans.className}>
      
      <body>
        {/* <Header/> */}
        <main className="min-h-screen flex flex-col items-center">
          {children}
        </main>
      </body>
    </html>
  )
}
